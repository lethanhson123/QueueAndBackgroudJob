using Data.Databases.BackgroundTask;
using Data.Databases.CMS_EMBERPLUS;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
//using RestSharp;

namespace BusinessServices.Services
{
    public partial class MplusOrderNotSyncYetServices : IMplusOrderNotSyncYetServices
    {
        private readonly CmsEmberplusContext _dbCmsEmberplusDevContext;
        private readonly OnlineSyncDataContext _dbOnlineSyncDataContext;
        private readonly BackgroundTaskContext _dbBackgroundTaskContext;
        private readonly ISignalRServices _signalRServices;
        private readonly IMapper _mapper;
        private readonly ILogger<MplusOrderNotSyncYetServices> _loggerWindows;
        public MplusOrderNotSyncYetServices(
            CmsEmberplusContext dbCmsEmberplusDevContext,
            OnlineSyncDataContext dbOnlineSyncDataContext,
            BackgroundTaskContext dbBackgroundTaskContext,
            ISignalRServices signalRServices,
            IMapper mapper, 
            ILogger<MplusOrderNotSyncYetServices> loggerWindows) 
        {
            _dbCmsEmberplusDevContext = dbCmsEmberplusDevContext;
            _dbOnlineSyncDataContext = dbOnlineSyncDataContext;
            _dbBackgroundTaskContext = dbBackgroundTaskContext;
            _signalRServices = signalRServices;
            _mapper = mapper;
            _loggerWindows = loggerWindows;
        }

        #region Publisher
        public async Task<List<SyncOrderMplusToFFQueueModel>> LoadUnSyncOrderFromMPlus()
        {
            List<SyncOrderMplusToFFQueueModel> inQueueItems = new List<SyncOrderMplusToFFQueueModel>();

            var _companies = await _dbCmsEmberplusDevContext.Companies
                .Where(c => c.Host.Equals("localhost") && c.Status.Equals(1))
                .Distinct()
                .ToListAsync();

            var pushedQueuesDB = await _dbBackgroundTaskContext.PushQueues
                .Where(p => p.Action.Equals(ActionTypes.SYNC_ORDER.ToString().ToUpper()))
                .Select(p => p.Queue)
                .ToListAsync();
            List<PushQueue> _pushQueueNewListToDB = new List<PushQueue>();

            _companies.ForEach(com =>
            {
                var listWebOrdersIds = _dbCmsEmberplusDevContext.WebOrders
                    .Where(t =>
                        t.CompanyId.Equals(com.CompanyId) &&
                        t.SyncEnable.Equals(true) &&
                        t.PaymentStatus.Equals("Paid") &&
                        t.OrderStatus.Equals("Processing") &&
                        t.DeliveryRequestCreated != true &&
                        t.Status == (int)Utilities.MPlusSyncOrderUtility.RecordStatus.Active &&
                        !t.TpforderId.HasValue)
                    .Select(t => t.Id)
                    .Distinct()
                    .ToList();

                if (listWebOrdersIds.Count > 0)
                {
                    listWebOrdersIds.ForEach(wo =>
                    {
                        MplusOrderNotSyncYetModel _mplusOrderNotSyncYetItem = new MplusOrderNotSyncYetModel();
                        _mplusOrderNotSyncYetItem.WebOrderId = wo;
                        _mplusOrderNotSyncYetItem.CompanyID = (int)com.CompanyId;

                        if (!pushedQueuesDB.Contains(JsonConvert.SerializeObject(_mplusOrderNotSyncYetItem)))
                        {
                            var _mplusDeliveryNotSyncYetQueue = _mapper.Map<SyncOrderMplusToFFQueueModel>(_mplusOrderNotSyncYetItem);
                            _mplusDeliveryNotSyncYetQueue.create = DateTime.UtcNow;
                            _mplusDeliveryNotSyncYetQueue.action = ActionTypes.SYNC_ORDER.ToString().ToUpper();
                            _mplusDeliveryNotSyncYetQueue.status = ActionStatus.NEW.ToString().ToUpper();

                            inQueueItems.Add(_mplusDeliveryNotSyncYetQueue);

                            var _push = _mapper.Map<PushQueue>(_mplusDeliveryNotSyncYetQueue);
                            _pushQueueNewListToDB.Add(_push);
                        }

                    });
                }
            });

            if (_pushQueueNewListToDB.Count > 0)
            {
                _dbBackgroundTaskContext.PushQueues.AddRange(_pushQueueNewListToDB);
                await _dbBackgroundTaskContext.SaveChangesAsync();
            }

            return inQueueItems;
        }
        #endregion

        #region Subscriber
        public Dictionary<string, object> subcriberSyncOrder(SyncOrderMplusToFFQueueModel data)
        {
            Dictionary<string, object> rs = new Dictionary<string, object>();

            var mPlusWebOrders = _dbCmsEmberplusDevContext.WebOrders
            .Where(o1 => o1.CompanyId.Equals(data.item.CompanyID) && o1.Id.Equals(data.item.WebOrderId))
            .FirstOrDefault();

            var company = _dbCmsEmberplusDevContext.Companies
                    .Where(c => c.CompanyId.Equals(data.item.CompanyID) && c.Status.Equals(1))
                    .FirstOrDefault();

            var config = _dbCmsEmberplusDevContext.CmsConfigurations
                .Where(cf => cf.CompanyId.Equals(data.item.CompanyID) && cf.Status.Equals(1))
                .FirstOrDefault();

            if (company == null || config == null)
            {
                _loggerWindows.LogInformation("[{orderId}] company is null CompanyID={CompanyID}", mPlusWebOrders.Id, data.item.CompanyID);
                rs["c"] = ConstantCode.SOME_ORDER_SYNC_FAIL;
                rs["m"] = string.Format("[{0}] company is null CompanyID={1}", mPlusWebOrders.Id, data.item.CompanyID);
                return rs;
            }
            if (String.IsNullOrWhiteSpace(config.OrderPrefix))
            {
                _loggerWindows.LogInformation("[{orderID}] Config > OrderPrefix is null ConfigID='{configID}'", mPlusWebOrders.Id, config.Id);
                rs["c"] = ConstantCode.SOME_ORDER_SYNC_FAIL;
                rs["m"] = string.Format("[{0}] Config > OrderPrefix is null ConfigID='{1}'", mPlusWebOrders.Id, config.Id);
                return rs;
            }

            //Check if Order already sync
            if (mPlusWebOrders.TpforderId.HasValue || mPlusWebOrders.SyncStatus.Equals(SyncStatusOrder.Synchronized.ToString()))
            {
                rs["c"] = ConstantCode.SUCCESSFULL;
                rs["m"] = ConstantMessage.SUCCESSFULL;
                return rs;
            }

            IEnumerable<SiteStoreInfo> AllStores = _signalRServices.GetSiteStores();
            var currentStore = AllStores.FirstOrDefault(w => w.CatalogueId == company.CatalogueId && w.StoreStatus.ToLower() == EntityStatus.Active.GetDisplayName().ToLower());

            var syncO = ParseOrder(data, mPlusWebOrders, company, config);
            if (syncO != null)
            {
                var syncOrder = NeedOrderSync(JsonConvert.SerializeObject(syncO), currentStore, false, company.CatalogueId);

                if (syncOrder.Errors.Count > 0)
                {
                    if (String.IsNullOrEmpty(syncOrder.TPFOrderID) || String.IsNullOrEmpty(syncOrder.PONumber))
                    {
                        rs["c"] = ConstantCode.SOME_ORDER_SYNC_FAIL;
                        rs["m"] = JsonConvert.SerializeObject(syncOrder);
                        return rs;
                    } 
                }    
                var task = SendRequest(syncOrder, company, config, currentStore);
            }
            else
            {
                rs["c"] = ConstantCode.SOME_ORDER_SYNC_FAIL;
                rs["m"] = JsonConvert.SerializeObject(syncO);
                return rs;
            }    


            rs["c"] = ConstantCode.SUCCESSFULL;
            rs["m"] = ConstantMessage.SUCCESSFULL;
            return rs;
        }

        #region SyncOrder
        private SyncOrderRequest ParseOrder(SyncOrderMplusToFFQueueModel data, WebOrder order, Company _com, CmsConfiguration _config)
        {
            try
            {
                var extendFields = _dbCmsEmberplusDevContext.ExtendFields
                    .Where(e => e.OwnerId.Equals(order.Id.ToString()) && e.OwnerModule == "WebOrder.ExtendField")
                    .ToList();

                SyncOrderRequest orderRepo = new SyncOrderRequest
                {
                    PaymentType = order.PaymentType,
                    Status = order.OrderStatus,
                    Currency = order.Currency,
                    CatalogueID = (int)_com.CatalogueId,
                    ClientID = (int)_com.ClientId,
                    PONumber = (_config == null ? ("ONC" + data.item.CompanyID) : String.IsNullOrWhiteSpace(_config.OrderPrefix) ? ("ONC" + data.item.CompanyID) : _config.OrderPrefix) + order.Id.ToString(),
                    DiscountAmount = (order.CreditSubTotal ?? 0),
                    DiscountTax = (order.CreditGst ?? 0),
                    DiscountTaxRate = (order.CreditGst ?? 0) > 0 ? (order.Gst ?? 0) : 0,
                    FreightFee = (order.ShippingSubTotalPrice ?? 0),
                    Txnref = order.TransationRef,
                    Created = (DateTime)order.OrderDate,
                    Notes = order.Notes,
                    TradingTerms = string.Empty,
                    FreightTax = (order.ShippingTotalPrice ?? 0) - (order.ShippingSubTotalPrice ?? 0),
                    FreightTaxRate = order.Gst ?? 0,
                    RefType = order.OrderType,
                    ShippingType = order.ShippingType,
                    ExtraInfo = extendFields.ToDictionary(t => t.Title, t => t.Value)

                };

                var addressShipping = _dbCmsEmberplusDevContext.MetaAddresses
                    .Where(ma => ma.OwnerId.Equals(order.Id.ToString()) && ma.OwnerModule == "WebOrder.Shipping")
                    .FirstOrDefault();
                if (addressShipping.Country.Trim().ToLower() != "Australia".Trim().ToLower())
                {
                    orderRepo.FreightTaxRate = 0;
                    orderRepo.FreightTax = 0;
                    orderRepo.FreightFee = (order.ShippingTotalPrice ?? 0);

                }

                var paymentTransation = _dbCmsEmberplusDevContext.PaymentTransations
                    .Where(pt => pt.OrderId.Equals(order.Id) && pt.Status.Equals(1))
                    .FirstOrDefault();
                orderRepo.PaymentTransation = new Models.MPlusSyncOrder.PaymentTransation
                {
                    TxnReference = paymentTransation.TransationId,
                    Currency = paymentTransation.Currency,
                    Paid = true,
                    Amount = paymentTransation.AmountReceive ?? 0,
                    ResponseCode = paymentTransation.ResponseCode,
                    ResponseText = paymentTransation.Response,
                    Created = (DateTime)(paymentTransation.PayRequest ?? order.OrderDate),
                    PayDate = (DateTime)(paymentTransation.PayResponse ?? order.OrderDate),
                    PaymentType = order.PaymentType,
                    PaypalClientId = paymentTransation.PaypalId ?? ""
                };

                var addressBilling = _dbCmsEmberplusDevContext.MetaAddresses
                    .Where(ma => ma.OwnerId.Equals(order.Id.ToString()) && ma.OwnerModule == "WebOrder.Billing")
                    .FirstOrDefault();
                orderRepo.Billing = new AddressInfo
                {
                    Email = addressBilling.Email,
                    LastName = addressBilling.LastName,
                    Phone = addressBilling.Phone,
                    FirstName = addressBilling.FirstName,
                    State = addressBilling.State,
                    Suburb = addressBilling.Suburb,
                    Country = addressBilling.Country,
                    Address1 = addressBilling.AddressLine1,
                    Address2 = addressBilling.AddressLine2,
                    CompanyName = addressBilling.CompanyName,
                    Postcode = addressBilling.PostCode
                };

                orderRepo.Delivery = new AddressInfo
                {
                    Email = addressShipping.Email,
                    LastName = addressShipping.LastName,
                    Phone = addressShipping.Phone,
                    FirstName = addressShipping.FirstName,
                    State = addressShipping.State,
                    Suburb = addressShipping.Suburb,
                    Country = addressShipping.Country,
                    Address1 = addressShipping.AddressLine1,
                    Address2 = addressShipping.AddressLine2,
                    CompanyName = addressShipping.CompanyName,
                    Postcode = addressShipping.PostCode
                };

                orderRepo.Contact = new AddressInfo
                {
                    Email = addressShipping.Email,
                    LastName = addressShipping.LastName,
                    Phone = addressShipping.Phone,
                    FirstName = addressShipping.FirstName,
                    State = addressShipping.State,
                    Suburb = addressShipping.Suburb,
                    Country = addressShipping.Country,
                    Address1 = addressShipping.AddressLine1,
                    Address2 = addressShipping.AddressLine2,
                    CompanyName = addressShipping.CompanyName,
                    Postcode = addressShipping.PostCode
                };

                var webOrderDetails = _dbCmsEmberplusDevContext.WebOrderDetails
                    .Where(wod => wod.OrderId.Equals(order.Id))
                    .ToList();
                var listProId = webOrderDetails.Select(t => t.ProductId);
                var listProduct = _dbCmsEmberplusDevContext.Products
                    .Where(p => listProId.Contains(p.Id))
                    .ToList();
                foreach (var item in webOrderDetails.Where(t => t.Quantity > 0 && t.ProductType != 11))
                {
                    int _quantity = item.Quantity ?? 0;
                    decimal _price = item.Price ?? 0;
                    decimal _totalGst = item.TotalGst ?? 0;
                    var detail = new SyncOrderDetail
                    {
                        TaxRate = item.Gst ?? 0,
                        Name = item.Name,
                        Qty = _quantity,
                        Price = _price, //- ((item.TotalGst ?? 0) / item.Quality),
                        //InternalCode = item.ProductType == 10 ? "P" + 235776.ToString("000000000") : "P" + long.Parse(item.Sku).ToString("000000000"),
                        InternalCode = listProduct.FirstOrDefault(p => p.Id.Equals(item.ProductId)).InternalCode,
                        PackItem = item.ProductType == 10,
                        QtyBackOrder = 0,
                        Comments = string.Empty,
                        Tax = _totalGst / _quantity,
                        InventoryCode = listProduct.FirstOrDefault(t => t.Id.Equals(item.ProductId))?.VirtualCode ?? item.ProductId.ToString(),
                        RawData = item.RedeemRawData,
                        OcdetailID = item.Id,
                        WarehouseID = item.PrimaryWh,
                        IsFF_Item = true// order.Details.Any(t=>t.IsRedeem|| t.ProductType == 9 || t.ProductType == 8)

                    };
                    if (item.ProductType == 9)
                    {
                        detail.Personalisation = new Personalisation_OrderConnection
                        {
                            Type = "Text",
                            Text = new List<string> { item.PersonalizedLetter }
                        };
                    }
                    if (item.ProductType == 8)
                    {
                        detail.Personalisation = new Personalisation_OrderConnection
                        {
                            Type = "Image",
                            Text = new List<string> { item.PersonalizedData?.Split('/').Last() ?? "" }
                        };
                    }
                    orderRepo.Orderdetails.Add(detail);
                }
                return orderRepo;
            }
            catch (Exception e)
            {
                _loggerWindows.LogError(e, "OrderConnection > ParseOrder: orderId={orderId} . {Message}", order.Id, e.Message);
                return null;
            }
        }

        public SyncOrderResponse NeedOrderSync(string syncOrderRequest, SiteStoreInfo currentStore, bool isTesting = false, int? catalogueId = 0)
        {
            List<string> errorsList = new List<string>();
            SyncOrderResponse result = new SyncOrderResponse();
            List<ValidationResult> validationResult = new List<ValidationResult>();
            string breakPoint = "NeedOrderSync -> ";

            try
            {
                breakPoint += "Check Store Site Id -> ";
                if (currentStore == null || currentStore.StoreSiteId <= 0)
                {
                    errorsList.Add("Token's incorrect or Store Site Id not found");
                    goto EndAction;
                }

                breakPoint += "Check permission -> ";
                if (!currentStore.RoleIDs.Exists(s => s == SynchRole.OrderSync))
                {
                    errorsList.Add(String.Format("Permission denied for {0}", SynchRole.OrderSync.GetDisplayDescription()));
                    goto EndAction;
                }

                breakPoint += "Convert To SyncOrderRepo -> ";
                SyncOrderRepo syncOrder = new SyncOrderRepo();
                if (currentStore.StoreType == Utilities.MPlusSyncOrderUtility.StoreType.WLB)
                {
                    if (!String.IsNullOrWhiteSpace(syncOrderRequest))
                    {
                        SyncOrderRequest orderRequest = JsonConvert.DeserializeObject<SyncOrderRequest>(syncOrderRequest);
                        syncOrder = _mapper.Map<SyncOrderRequest, SyncOrderRepo>(orderRequest);
                    }
                }

                breakPoint += "SyncOrderView verify -> ";
                if (!ValidationHelper.IsValid(syncOrder, out validationResult))
                {
                    errorsList = validationResult.Select(s => s.ErrorMessage).ToList();
                    goto EndAction;
                }

                //Utility.SaveRawOrderInfo(syncOrderRequest, syncOrder.PONumber, currentStore.StoreType);
                //breakPoint = "create Sync Repository to sync";
                breakPoint += "Call SyncRepository SyncOrderView parse to json to store -> ";
                //isTesting = true;
                List<OrderSyncTrackingSignalR> trackings = new List<OrderSyncTrackingSignalR>();
                if (!currentStore.RoleIDs.Exists(s => s == SynchRole.OrderPaid))
                {
                    isTesting = true;
                }

                string pONumber = !isTesting ? syncOrder.PONumber : String.Format("T{0}", syncOrder.PONumber);
                long tpfOrderId = _signalRServices.GetTPFOrderNumber(pONumber);
                OrderStatusTracking tracking = new OrderStatusTracking();

                if (tpfOrderId <= 0)
                {
                    breakPoint += "Add tracking order sync -> ";
                    trackings.Add(new OrderSyncTrackingSignalR()
                    {
                        TPFOrderID = 0,
                        PONumber = pONumber,
                        OrderStatus = syncOrder.Status,
                        StoreId = currentStore.StoreSiteId,
                        PendingDuration = isTesting ? 12 : 0,
                        RawData = JsonConvert.SerializeObject(syncOrder),
                        SyncStatus = isTesting ? SyncStatus.Testing : SyncStatus.Pending,
                    });

                    //Insert to OrderSyncTracking table (TPFOrderID = 0)
                    _signalRServices.AddOrderTrackingExtent(trackings);
                    tpfOrderId = _signalRServices.CreateOrderForWLB(syncOrder, currentStore, isTesting, out errorsList);
                    if (errorsList.Count() == 0)
                    {
                        string msgSeccess = string.Format(
                            "Created order successfully with StoreId: {0} PoNumber: {1} TpfOrderId: {2}",
                            currentStore.StoreSiteId,
                            syncOrder.PONumber,
                            tpfOrderId);
                    }
                }
                else
                {
                    errorsList.Add(String.Format("PO Number #{0} is existed with TpfOrderId #{1}", syncOrder.PONumber, tpfOrderId.ToString()));
                }

                if (tpfOrderId > 0)
                {
                    breakPoint += "Get Order Tracking Info -> ";
                    tracking = _signalRServices.GetOrderStatusTracking(pONumber);
                    result.OrderStatus = Utility.ConvertShopifyOrderStatus(tracking.OrderStatus, tracking.DeliveryStatus).GetDisplayName();
                    result.TPFOrderID = tracking.TPFOrderID.ToString();
                    result.PONumber = tracking.PONumber;
                    result.GuiID = tracking.RGuid.ToString();
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "NeedOrderSync Exception: {Message}", ex.Message);
            }

        EndAction:
            if (errorsList.Count() > 0)
            {
                result.Errors = errorsList;
                string errorsLists = "";
                errorsList.ForEach(er =>
                {
                    errorsLists += "\r\n - " + er;
                });
                _loggerWindows.LogCritical("NeedOrderSync Error: SyncOrderView is invalid : \r\n {errorsList}", errorsLists);
            }

            return result;
        }

        private Dictionary<string, object> SendRequest(SyncOrderResponse orderRepo, Company _com, CmsConfiguration _config, SiteStoreInfo currentStore)
        {
            Dictionary<string, object> rs = new Dictionary<string, object>();

            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            var MplusWebOrder = _dbCmsEmberplusDevContext.WebOrders
                    .Where(o => long.Parse(orderRepo.PONumber
                        .Replace(_config.OrderPrefix ?? "", "")
                        .Replace("T", "")
                        .Replace("ONC" + _com.CompanyId, "")).Equals(o.Id))
                    .FirstOrDefault();
            var webOrder = _mapper.Map<WebOrder_OrderConnection>(MplusWebOrder);
            int ac = 0;

            try
            {
                if (orderRepo.Errors.Count == 0)
                {
                    bool updateStock = false;
                    var updated = true;

                    if (webOrder.CompanyID == _com.CompanyId)
                    {
                        if (webOrder.TPFOrderID == null || !webOrder.TPFOrderID.HasValue)
                        {
                            updateStock = true;
                        }

                        webOrder.SyncStatus = SyncStatusOrder.Synchronized.ToString();
                        webOrder.TPFOrderID = long.Parse(orderRepo.TPFOrderID);
                        if (webOrder.DeliveryTrackings == null)
                        {
                            webOrder.DeliveryTrackings = new List<WebOrderDeliveryTracking>();
                        }
                        webOrder.DeliveryTrackings.ForEach((it) =>
                        {
                            it.Status = (int)RecordStatus.InActive;
                        });
                        if (orderRepo.Deliveries != null && orderRepo.Deliveries.Count() > 0)
                        {
                            foreach (var item1 in orderRepo.Deliveries)
                            {
                                var wTracking =
                                    webOrder.DeliveryTrackings.FirstOrDefault(t =>
                                        t.TrackingNo == item1.TrackingNo);

                                if (wTracking != null)
                                {
                                    wTracking.Status = 1;
                                    wTracking.TrackingNo = item1.TrackingNo;
                                    wTracking.CarrierName = item1.CarrierName;
                                    wTracking.CarrierUrl = item1.CarrierUrl;
                                    wTracking.ProcessedDate = item1.ProcessedDate;
                                    wTracking.WhId = item1.WhId;
                                    //wTracking.ActionType = ActionType.Update;

                                }
                                else
                                {
                                    wTracking = new WebOrderDeliveryTracking
                                    {
                                        Status = 1,
                                        TrackingNo = item1.TrackingNo,
                                        CarrierName = item1.CarrierName,
                                        CarrierUrl = item1.CarrierUrl,
                                        ProcessedDate = item1.ProcessedDate,
                                        WhId = item1.WhId,
                                        //ActionType = ActionType.Create,
                                        IsSendMail = false
                                    };
                                    webOrder.DeliveryTrackings.Add(wTracking);
                                }
                            }
                        }

                        webOrder.TPFOrderSyncDate = DateTime.Now;
                        if (!String.IsNullOrWhiteSpace(webOrder.Notes) &&
                            webOrder.Notes.IndexOf(orderRepo.Notes, StringComparison.Ordinal) == -1)
                        {
                            webOrder.Notes += "," + orderRepo.Notes;
                        }

                        MplusWebOrder.SyncStatus = webOrder.SyncStatus;
                        MplusWebOrder.TpforderId = webOrder.TPFOrderID;
                        MplusWebOrder.TpforderSyncDate = webOrder.TPFOrderSyncDate;
                        MplusWebOrder.Notes = webOrder.Notes;
                        _dbCmsEmberplusDevContext.WebOrders.Update(MplusWebOrder);
                        ac = _dbCmsEmberplusDevContext.SaveChanges();

                        if (ac == 1)
                        {
                            if (webOrder.DeliveryTrackings.Any(t => !t.IsSendMail.HasValue || t.IsSendMail == false))
                            {
                                // call sendmail of Finn: /Task/TaskAction?command=DispatchEmail
                            }

                            if (updateStock)
                            {
                                var dataTable = new DataTable();
                                using (var command = _dbCmsEmberplusDevContext.Database.GetDbConnection().CreateCommand())
                                {
                                    command.CommandText = "sp_Order_UpdateStockAfterSync";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.CommandTimeout = 120; //2 min

                                    var resultParameter = new[]
                                    {
                                            new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "order_id", DbType = DbType.Int64, Value = webOrder.ID }
                                        };
                                    command.Parameters.AddRange(resultParameter);

                                    _dbCmsEmberplusDevContext.Database.OpenConnection();

                                    using (var result = command.ExecuteReader())
                                    {
                                        dataTable.Load(result);
                                    }
                                }
                            }
                        }

                    }

                    if (!String.IsNullOrWhiteSpace(orderRepo.GuiID))
                    {
                        if (dic.ContainsKey(orderRepo.GuiID))
                        {
                            dic.Remove(orderRepo.GuiID);
                        }
                        dic.Add(orderRepo.GuiID, updated);
                    }
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(orderRepo.TPFOrderID))
                    {
                        bool updateStock = false;
                        var updated = true;

                        if (webOrder.CompanyID == _com.CompanyId)
                        {
                            if (webOrder.TPFOrderID == null || !webOrder.TPFOrderID.HasValue)
                            {
                                updateStock = true;
                            }

                            webOrder.TPFOrderID = long.Parse(orderRepo.TPFOrderID);
                            if (webOrder.DeliveryTrackings == null)
                            {
                                webOrder.DeliveryTrackings = new List<WebOrderDeliveryTracking>();
                            }

                            webOrder.DeliveryTrackings.ForEach((it) =>
                            {
                                it.Status = (int)RecordStatus.InActive;
                            });

                            if (orderRepo.Deliveries != null && orderRepo.Deliveries.Count() > 0)
                            {
                                foreach (var item1 in orderRepo.Deliveries)
                                {
                                    var wTracking = webOrder.DeliveryTrackings.FirstOrDefault(t => t.TrackingNo == item1.TrackingNo);

                                    if (wTracking != null)
                                    {
                                        wTracking.Status = 1;
                                        wTracking.TrackingNo = item1.TrackingNo;
                                        wTracking.CarrierName = item1.CarrierName;
                                        wTracking.CarrierUrl = item1.CarrierUrl;
                                        wTracking.ProcessedDate = item1.ProcessedDate;
                                        wTracking.WhId = item1.WhId;

                                    }
                                    else
                                    {
                                        wTracking = new WebOrderDeliveryTracking
                                        {
                                            Status = 1,
                                            TrackingNo = item1.TrackingNo,
                                            CarrierName = item1.CarrierName,
                                            CarrierUrl = item1.CarrierUrl,
                                            ProcessedDate = item1.ProcessedDate,
                                            WhId = item1.WhId,
                                            IsSendMail = false
                                        };
                                        webOrder.DeliveryTrackings.Add(wTracking);

                                    }
                                }
                            }

                            webOrder.TPFOrderSyncDate = DateTime.Now;
                            if (!String.IsNullOrWhiteSpace(webOrder.Notes) && webOrder.Notes.IndexOf(orderRepo.Notes, StringComparison.Ordinal) == -1)
                            {
                                webOrder.Notes += "," + orderRepo.Notes;
                            }

                            if (webOrder.OrderStatus == OrderStatus.Cancelled.ToString())
                            {
                                string mes = "";
                                updated = CancelOrderProc(webOrder.ID.ToString(), webOrder.Notes, "TPF System", out mes);

                                if (dic.ContainsKey(orderRepo.GuiID))
                                {
                                    dic.Remove(orderRepo.GuiID);
                                }
                                dic.Add(orderRepo.GuiID, updated);

                                return rs;
                            }

                            var oldStatus = webOrder.OrderStatus;
                            webOrder.OrderStatus = orderRepo.OrderStatus;

                            MplusWebOrder.TpforderId = webOrder.TPFOrderID;
                            MplusWebOrder.TpforderSyncDate = webOrder.TPFOrderSyncDate;
                            MplusWebOrder.Notes = webOrder.Notes;
                            _dbCmsEmberplusDevContext.WebOrders.Update(MplusWebOrder);
                            ac = _dbCmsEmberplusDevContext.SaveChanges();
                            if (ac == 1) updated = true;
                            else updated = false;

                            if (updated)
                            {
                                if (webOrder.DeliveryTrackings.Any(t => !t.IsSendMail.HasValue || t.IsSendMail == false))
                                {
                                    // call sendmail of Finn: /Task/TaskAction?command=DispatchEmail
                                }

                                if (oldStatus != OrderStatus.Rejected.ToString() && webOrder.OrderStatus == OrderStatus.Rejected.ToString())
                                {
                                    // call sendmail of Finn: /Task/TaskAction?command=RejectedShopEmail
                                }

                                if (updateStock)
                                {
                                    var dataTable = new DataTable();
                                    using (var command = _dbCmsEmberplusDevContext.Database.GetDbConnection().CreateCommand())
                                    {
                                        command.CommandText = "sp_Order_UpdateStockAfterSync";
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.CommandTimeout = 120; //2 min

                                        var resultParameter = new[]
                                        {
                                            new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "order_id", DbType = DbType.Int64, Value = webOrder.ID }
                                        };
                                        command.Parameters.AddRange(resultParameter);

                                        _dbCmsEmberplusDevContext.Database.OpenConnection();

                                        using (var result = command.ExecuteReader())
                                        {
                                            dataTable.Load(result);
                                        }
                                    }
                                }
                            }

                        }

                        if (!String.IsNullOrWhiteSpace(orderRepo.GuiID))
                        {
                            if (dic.ContainsKey(orderRepo.GuiID))
                            {
                                dic.Remove(orderRepo.GuiID);
                            }
                            dic.Add(orderRepo.GuiID, updated);
                        }
                    }
                }

                ConfirmRequest(dic, currentStore, _com.CatalogueId);
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return rs;

        }

        private bool CancelOrderProc(string orderId, string note, string uName, out string mess)
        {
            mess = "";
            var updated = false;
            try
            {
                var dataTable = new DataTable();
                using (var command = _dbCmsEmberplusDevContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "sp_Order_Cancel";
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120; //2 min

                    command.Parameters.Add(new SqlParameter { ParameterName = "order_ids", SqlDbType = SqlDbType.NVarChar, Value = orderId, });
                    command.Parameters.Add(new SqlParameter { ParameterName = "note", SqlDbType = SqlDbType.NVarChar, Value = note, });
                    command.Parameters.Add(new SqlParameter { ParameterName = "cancel_by", SqlDbType = SqlDbType.NVarChar, Value = uName, });

                    _dbCmsEmberplusDevContext.Database.OpenConnection();

                    using (var result = command.ExecuteReader())
                    {
                        dataTable.Load(result);
                    }
                }
                if (dataTable == new DataTable())
                {
                    mess = "Update Database Error:CancelOrder with key=" + orderId;
                    return false;
                }

                var ocNum = dataTable.Rows[0][0].ToString();
                var wo = _dbCmsEmberplusDevContext.WebOrders
                    .Where(o => o.Id.Equals(ocNum))
                    .FirstOrDefault();

                var user = _dbCmsEmberplusDevContext.Users
                    .Where(u => u.UserId.Equals(wo.UserId))
                    .FirstOrDefault();
                int _upd = 0;
                if (!(wo.ReturnCredit ?? false))
                {
                    if (user != null)
                    {
                        if (wo.Credit > 0)
                        {
                            user.Credit += (wo.Credit.Value - 0);
                            _dbCmsEmberplusDevContext.Users.Update(user);
                            _upd = _dbCmsEmberplusDevContext.SaveChanges();
                            if (_upd == 1) updated = true;
                            else updated = false;

                            wo.ReturnCredit = updated;
                        }

                        var totalCredit = _dbCmsEmberplusDevContext.WebOrderDetails
                            .Where(t => t.ProductType == 11 && t.ReturnQty == false && t.OrderId.Equals(wo.Id))
                            .Sum(t => t.RedeemValue) ?? 0;

                        if (totalCredit > 0)
                        {
                            user.Credit += (0 - totalCredit);
                            _dbCmsEmberplusDevContext.Users.Update(user);
                            _dbCmsEmberplusDevContext.SaveChanges();
                        }
                        foreach (var itemDetail in _dbCmsEmberplusDevContext.WebOrderDetails.Where(t => t.ProductType == 11 && t.ReturnQty == false && t.OrderId.Equals(wo.Id)))
                        {
                            itemDetail.ReturnQty = true;
                        }
                    }
                    _dbCmsEmberplusDevContext.WebOrders.Update(wo);
                    _upd = _dbCmsEmberplusDevContext.SaveChanges();
                    if (_upd == 1) updated = true;
                    else updated = false;
                }

                if (!updated)
                {
                    mess = "Update Database Error:CancelOrder with key=" + wo.Id;
                }

            }
            catch (Exception e)
            {
                mess = e.Message;
                _loggerWindows.LogError(e, "{Message}", e.Message);
            }

            return updated;
        }

        private void ConfirmRequest(Dictionary<string, bool> codeFirm, SiteStoreInfo currentStore, int? catalogueId = 0)
        {
            List<string> errorsList = new List<string>();
            StringBuilder breakPoint = new StringBuilder("Start");

            breakPoint.Append(">> Check Rules");
            if (!currentStore.RoleIDs.Exists(s => s == SynchRole.TurnOffOrderSync))
            {
                errorsList.Add(String.Format("Permission denied for StoreID {0}", currentStore.StoreSiteId));
                goto EndAction;
            }

            breakPoint.Append(">> Check parameter");
            if (codeFirm != null && codeFirm.Count > 0)
            {
                var guids = new List<Guid>();

                foreach (var item in codeFirm)
                {
                    if (item.Value && !String.IsNullOrEmpty(item.Key))
                    {
                        var guid = new Guid(item.Key);
                        if (!guids.Any(g => g == guid))
                        {
                            guids.Add(guid);
                        }
                    }
                }

                if (guids.Any())
                {
                    TurnOffOrderSyncByGuid(guids);
                }
            }
        EndAction:
            return;
        }

        private bool TurnOffOrderSyncByGuid(List<Guid> guids)
        {
            bool result = false;
            string breakPoint = "Start";

            try
            {
                if (guids != null && guids.Count() > 0)
                {
                    var iGuids = guids.Distinct().Select(s => s.ToString());

                    breakPoint = "Parameters";
                    string listIGuids = "";
                    iGuids.ToList().ForEach(gu =>
                    {
                        listIGuids += gu.ToString() + ",";
                    });
                    listIGuids = listIGuids.TrimEnd(',');
                    var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "Guids", DbType = DbType.String, Value= listIGuids }
                    };

                    var sqlQuery = "UPDATE dbo.OrderSyncTracking SET SyncStatus=1, SyncDelStatus=1 WHERE RGuid IN (@Guids);";
                    breakPoint = "Connection database to execute";

                    using (var command = _dbOnlineSyncDataContext.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddRange(parameters);

                        _dbOnlineSyncDataContext.Database.OpenConnection();

                        var valResult = command.ExecuteNonQuery();
                        if (valResult > 0)
                        {
                            result = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "SubcriNotSyncOrderMberToFF -> TurnOffOrderSyncByGuid Exception: {Message}", ex.Message);
            }
            return result;
        }

        #endregion


        #endregion
    }
}
