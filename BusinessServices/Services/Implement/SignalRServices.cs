using Dapper;
using Microsoft.Data.SqlClient.Server;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;
using static Utilities.MPlusSyncOrderUtility.EnumExtensions;

namespace BusinessServices.Services.MPlusSyncOrder
{
    public class SignalRServices : ISignalRServices
    {
        private readonly OnlineSyncDataContext _dbOnlineSyncDataContext;
        private readonly TpfsystemContext _dbTpfsystemContext;
        private readonly Csversion1Context _dbCsversion1Context;
        private readonly Tpf2003Context _dbTpf2003Context;
        private readonly ILogger<SignalRServices> _loggerWindows;		
		public SignalRServices(
            OnlineSyncDataContext dbOnlineSyncDataContext,
            TpfsystemContext dbTpfsystemContext,
            Csversion1Context dbCsversion1Context,
            Tpf2003Context dbTpf2003Context,
            ILogger<SignalRServices> loggerWindows)
        {
            _dbOnlineSyncDataContext = dbOnlineSyncDataContext;
            _dbTpfsystemContext = dbTpfsystemContext;
            _dbCsversion1Context = dbCsversion1Context;
            _dbTpf2003Context = dbTpf2003Context;
            _loggerWindows = loggerWindows;

        
        }

        public IEnumerable<SiteStoreInfo> GetSiteStores()
        {
            string breakPoint = "Start";
            IEnumerable<SiteStoreInfo> result = null;
            try
            {       

				breakPoint = "build parameters";
                var parameters = new[]
                {
                    new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "CatStatus", DbType = DbType.Boolean, Value = true }
                };
                breakPoint = "connection database to get data";
                string sqlQuery = "SELECT * FROM [dbo].[v_SiteStoreInfo] WHERE Active = @CatStatus ";
                using (var command = _dbOnlineSyncDataContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    _dbOnlineSyncDataContext.Database.OpenConnection();

                    DataTable dataTable = new DataTable();
                    using (var dt = command.ExecuteReader())
                    {
                        dataTable.Load(dt);
                    }
                    result = dataTable.ToIEnumerable<SiteStoreInfo>();

                    _loggerWindows.LogInformation("result={result}.", JsonConvert.SerializeObject(result));
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Get Tpf Order Id or Order External Checking
        /// </summary>
        /// <param name="poNumber"></param>
        /// <returns></returns>
        public long GetTPFOrderNumber(string poNumber)
        {
            long result = 0;
            string breakPoint = "Start";
            try
            {
                breakPoint = "build parameters";
                var parameters = new[]
                {
                    new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "poNumber", DbType = DbType.String, Value = poNumber }
                };
                //string sqlQuery = "SELECT top 1 ocid  FROM [dbo].[orderconf] WHERE isMagento=1 AND poNumber=@poNumber ";
                string sqlQuery = "SELECT top 1 * FROM [dbo].[orderconf] WHERE isMagento=1 AND poNumber=@poNumber ";

                breakPoint = "connection database to get data";
                using (var command = _dbTpfsystemContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);
                    _dbTpfsystemContext.Database.OpenConnection();

                    DataTable dataTable = new DataTable();
                    using (var dt = command.ExecuteReader())
                    {
                        dataTable.Load(dt);
                    }
                    if (dataTable.Rows.Count > 0)
                    {
                        string _orderconf = dataTable.Rows[0]["ocid"].ToString();
                        if (!String.IsNullOrEmpty(_orderconf))
                        {
                            result = long.Parse(_orderconf);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Add order track with status
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public bool AddOrderTrackingExtent(IEnumerable<OrderSyncTrackingSignalR> orders)
        {
            bool result = false;
            string breakPoint = "Start";

            try
            {
                if (orders != null && orders.Count() > 0)
                {
                    //DataTable tblOrderNote = new DataTable();
                    //tblOrderNote.Columns.AddRange(new DataColumn[7] {
                    //    new DataColumn("TpfOrderId", typeof(long)),
                    //    new DataColumn("StoreId",typeof(int)),
                    //    new DataColumn("PoNumber",typeof(string)),
                    //    new DataColumn("PendingDuration", typeof(int)),
                    //    new DataColumn("OrderStatus", typeof(string)),
                    //    new DataColumn("RawData", typeof(string)),
                    //    new DataColumn("SyncStatus",typeof(int)),
                    //});

                    //foreach (var item in orders)
                    //{
                    //    tblOrderNote.Rows.Add(
                    //        item.TPFOrderID,
                    //        item.StoreId,
                    //        item.PONumber.Trim(),
                    //        item.PendingDuration,
                    //        item.OrderStatus,
                    //        item.RawData,
                    //        (int)item.SyncStatus
                    //    );
                    //}
                    List<SqlDataRecord> tblOrderNote = new List<SqlDataRecord>();
                    SqlMetaData[] myRecordSchema =  {
                        new SqlMetaData("TpfOrderId", SqlDbType.BigInt),
                        new SqlMetaData("StoreId", SqlDbType.Int),
                        new SqlMetaData("PoNumber", SqlDbType.VarChar, 4000),
                        new SqlMetaData("PendingDuration", SqlDbType.Int),
                        new SqlMetaData("OrderStatus", SqlDbType.VarChar, 4000),
                        new SqlMetaData("RawData", SqlDbType.VarChar, 4000),
                        new SqlMetaData("SyncStatus", SqlDbType.Int)
                 };
                    foreach (var item in orders)
                    {
                        var record = new SqlDataRecord(myRecordSchema);
                        record.SetInt64(0, item.TPFOrderID);
                        record.SetInt32(1, item.StoreId);
                        record.SetString(2, item.PONumber.Trim());
                        record.SetInt32(3, item.PendingDuration);
                        record.SetString(4, item.OrderStatus);
                        record.SetString(5, item.RawData);
                        record.SetInt32(6, (int)item.SyncStatus);

                        tblOrderNote.Add(record);
                    }

                    breakPoint = "Parameters";
                    //var parameters = new DynamicParameters();
                    //parameters.Add("@OrderTracking", tblOrderNote.AsTableValuedParameter("dbo.UDT_OrderSyncTracking"));
                    //parameters.Add("@MessageDisplay", dbType: DbType.String, direction: ParameterDirection.Output, size: 4000);
                    //parameters.Add("@isSuccess", dbType: DbType.Boolean, direction: ParameterDirection.Output);
                    var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "OrderTracking", SqlDbType = SqlDbType.Structured, Value = tblOrderNote },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "MessageDisplay", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 4000 },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "isSuccess", DbType = DbType.Boolean, Direction = ParameterDirection.Output }
                    };

                    var sqlQuery = "sp_AddOrderTrackingExtent";
                    breakPoint = "connection database to execute stored procedure";
                    using (var command = _dbOnlineSyncDataContext.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);

                        _dbOnlineSyncDataContext.Database.OpenConnection();

                        using (var _query = command.ExecuteReader())
                        {
                            //result = parameters[2].Get<bool>("@isSuccess");
                            result = (bool)parameters[2].Value;
                        }
                        
                        if (!result)
                        {
                            //_loggerWindows.LogCritical("AddOrderSyncTrackingExtent Error: {Message}", parameters[1].Get<string>("@MessageDisplay"));
                            _loggerWindows.LogCritical("AddOrderSyncTrackingExtent Error: {Message}", parameters[1].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Convert SyncOrderView to OrderRepository
        /// And then store this order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public long CreateOrderForWLB(SyncOrderRepo syncOrder, SiteStoreInfo storeInfo, bool isTesting, out List<string> errorNotifications)
        {
            long result = 0;
            errorNotifications = new List<string>();
            List<ValidationResult> validationResult = new List<ValidationResult>();
            string breakPoint = "Start";

            try
            {
                if (syncOrder.Orderdetails == null || syncOrder.Orderdetails.Count == 0)
                {
                    errorNotifications.Add("Order Details is blank");
                    goto EndAction;
                }

                breakPoint += ">>Get Catalogue Info";
                CatalogueSignalR catalogue = GetCatalogueById(syncOrder.CatalogueID);
                if (catalogue == null || catalogue.Id == 0)
                {
                    errorNotifications.Add("Could not find catalogue " + syncOrder.CatalogueID);
                    goto EndAction;
                }

                breakPoint += ">>Check Po Number";
                if (isTesting)
                {
                    syncOrder.PONumber = String.Format("T{0}", syncOrder.PONumber);
                }

                var tpfOrderId = GetTPFOrderNumber(syncOrder.PONumber);
                if (tpfOrderId > 0)
                {
                    errorNotifications.Add(String.Format("PO Number #{0} is existed with TpfOrderId #{1}", syncOrder.PONumber, tpfOrderId.ToString()));
                    result = tpfOrderId;
                    goto EndAction;
                }

                List<OrderNote> orderNotes = new List<OrderNote>();

                #region Add Note
                orderNotes.Add(new OrderNote()
                {
                    Note = String.Format("Imported from {1} with PoNumber#({0}).", syncOrder.PONumber, storeInfo.StoreType.GetDisplayShortName())
                });
                #endregion

                using (var orderRepo = new OrderRepository())
                {
                    breakPoint += ">>order general info";
                    #region order general info and catalogue Info
                    orderRepo.CatalogueID = catalogue.Id;

                    orderRepo.PromotionName = String.Format("{0} {1} order", catalogue.Name, isTesting ? "Test" : "");

                    if (syncOrder.ClientID > 0 && syncOrder.ClientID != catalogue.CashClientId)
                    {
                        string warningData = String.Format("Cash ClientId #{3} of online store {2} is not the same with in the catalogue {0} with Cash Client Id {4} and #PoNumber {1}", catalogue.Name, syncOrder.PONumber, storeInfo.CatalogueName, syncOrder.ClientID, catalogue.CashClientId);
                        errorNotifications.Add(warningData);
                    }

                    orderRepo.ClientID = catalogue.CashClientId;
                    orderRepo.ToBeInvoiced = true;
                    orderRepo.PONumber = syncOrder.PONumber;
                    orderRepo.Exchangerate = syncOrder.ExchangeRate;
                    orderRepo.Currency = syncOrder.Currency;

                    //Set up Royalty
                    if (!String.IsNullOrEmpty(syncOrder.RefType) && !String.IsNullOrWhiteSpace(syncOrder.RefType))
                    {
                        orderRepo.RefType = syncOrder.RefType.ToUpper();
                    }
                    //Add position for FF Team processing Shipping Type on 13-08-2021
                    orderRepo.Position = syncOrder.ShippingType;

                    orderRepo.Closed = true;
                    orderRepo.CostCentre = "";

                    orderRepo.DeliveryDate = DateTime.Now;
                    orderRepo.DeliveryNotesToWarehouse = "";
                    orderRepo.Disclaimer = "";
                    orderRepo.FreeOnBoard = false;
                    orderRepo.OnlineOrder = true;
                    orderRepo.Ordergroup = "External";

                    orderRepo.IsMagento = true;

                    orderRepo.SendInvoiceWithGoods = true;
                    orderRepo.HandledBy = catalogue.HandledBy;
                    orderRepo.ProcessedBy = 332;
                    orderRepo.Enteredby = 332;
                    orderRepo.ProfileID = 0;

                    orderRepo.Trackingcode = "";
                    orderRepo.Vendorno = "";
                    orderRepo.Notes = !String.IsNullOrEmpty(syncOrder.Notes) ? syncOrder.Notes : "";
                    #endregion

                    #region Business logic rules for catalogues            
                    orderRepo.Onhold = false;
                    if (!String.IsNullOrEmpty(syncOrder.Delivery.Country) && !Regex.IsMatch(syncOrder.Delivery.Country, "australia", RegexOptions.IgnoreCase))
                    {
                        //orderRepo.Exchangerate = 0.0m;
                        if (storeInfo.RoleIDs.Exists(s => s == SynchRole.SetOnHoldOrder))
                        {
                            orderRepo.Onhold = true;
                            //orderRepo.Exchangerate = 0.0m;
                        }
                    }
                    #endregion

                    #region Creating new order - Set contact details
                    breakPoint += ">>Contact details";
                    orderRepo.Contact = syncOrder.Contact;

                    breakPoint += ">>Delivery details";
                    orderRepo.Delivery = syncOrder.Delivery;
                    if (String.IsNullOrEmpty(syncOrder.Delivery.Attention) || String.IsNullOrWhiteSpace(syncOrder.Delivery.Attention))
                    {
                        orderRepo.Delivery.Attention = String.Format("{0} {1}", syncOrder.Delivery.FirstName, syncOrder.Delivery.LastName);
                        orderRepo.Delivery.FirstName = syncOrder.Delivery.FirstName;
                        orderRepo.Delivery.LastName = syncOrder.Delivery.LastName;
                    }

                    breakPoint += ">>Billing details";
                    orderRepo.Billing = syncOrder.Billing;
                    if (String.IsNullOrEmpty(syncOrder.Billing.Attention) || String.IsNullOrWhiteSpace(syncOrder.Billing.Attention))
                    {
                        orderRepo.Billing.Attention = String.Format("{0} {1}", syncOrder.Billing.FirstName, syncOrder.Billing.LastName);
                    }
                    #endregion

                    #region Creating new order - Set payment info
                    breakPoint += ">>Check Payment Info";
                    PaymentMethod payment = Utility.DeterminePaymentMethodWLB(syncOrder.PaymentType);

                    List<PaymentMethod> AllowPaymentMethods = new List<PaymentMethod>() { PaymentMethod.Account, PaymentMethod.CreditCard, PaymentMethod.PayPal };
                    if (!AllowPaymentMethods.Exists(s => s == payment))
                    {
                        errorNotifications.Add(String.Format("Sync {2}: Reject the order #{0} with payment method {1}", syncOrder.PONumber, syncOrder.Status, storeInfo.StoreType.GetDisplayDescription()));
                    }

                    orderRepo.PayOption = payment;
                    OrderStatusSync orderStatus = OrderStatusSync.AwaitingPayment;
                    if (storeInfo.StoreType == StoreType.WLB)
                    {
                        orderStatus = Utility.DetermineWLBOrderStatus(syncOrder.Status);
                    }
                    else if (storeInfo.StoreType == StoreType.Shopify)
                    {
                        orderStatus = Utility.DetermineShopifyOrderStatus(syncOrder.Status);
                    }

                    orderRepo.TradingTerms = TradingTerms.PREPAYMENT;
                    CreditCardTransaction creditCard = new CreditCardTransaction();
                    PaypalTransaction paypalTransaction = new PaypalTransaction();

                    switch (payment)
                    {
                        case PaymentMethod.CreditCard:
                            orderRepo.Txnref = syncOrder.Txnref;
                            //check creadit transaction

                            creditCard.PromotionName = orderRepo.PromotionName;

                            creditCard.CustomerEmail = orderRepo.Billing.Email;
                            creditCard.CustomerName = String.Format("{0} {1}", orderRepo.Billing.FirstName, orderRepo.Billing.LastName);

                            creditCard.TxnReference = syncOrder.creditCardTran.TxnReference;
                            creditCard.ResponseCode = syncOrder.creditCardTran.ResponseCode;
                            creditCard.ResponseText = syncOrder.creditCardTran.ResponseText;
                            creditCard.Amount = syncOrder.creditCardTran.Amount;

                            if (Regex.IsMatch(syncOrder.PaymentType, PaymentTypeOfWLB.ANZCreditCard.GetDisplayName(), RegexOptions.IgnoreCase))
                            {
                                creditCard.Bank = "Hos";
                                creditCard.CardType = syncOrder.creditCardTran.CardType;
                                creditCard.CardNumber = syncOrder.creditCardTran.CardNumber;
                            }
                            else if (Regex.IsMatch(syncOrder.PaymentType, PaymentTypeOfWLB.SecurePayCreditCard.GetDisplayName(), RegexOptions.IgnoreCase))
                            {
                                creditCard.Bank = PaymentTypeOfWLB.SecurePayCreditCard.GetDisplayName().Substring(0, 3);
                                creditCard.CardType = "SecurePay";
                                creditCard.CardNumber = syncOrder.creditCardTran.CardNumber;
                            }
                            else if (Regex.IsMatch(syncOrder.PaymentType, PaymentTypeOfWLB.ANZCyberSource.GetDisplayName(), RegexOptions.IgnoreCase))
                            {
                                creditCard.Bank = PaymentTypeOfWLB.ANZCyberSource.GetDisplayShortName();
                                creditCard.CardType = syncOrder.creditCardTran.CardType;
                                creditCard.CardNumber = syncOrder.creditCardTran.CardNumber;
                            }

                            creditCard.Currency = syncOrder.creditCardTran.Currency;
                            creditCard.Paid = syncOrder.creditCardTran.Paid;
                            creditCard.PayDate = syncOrder.creditCardTran.PayDate;
                            creditCard.OrderNumber = orderRepo.OrderNumber.ToString();
                            creditCard.ProcessedBy = creditCard.CustomerName;

                            break;
                        case PaymentMethod.Account:
                            //syncOrder.TradingTerms = "30 days";
                            orderRepo.TradingTerms = Utility.DetermineTradingTerms(syncOrder.TradingTerms);
                            //check Account Info
                            //orderStatus = OrderStatus.AwaitingPayment;
                            break;
                        case PaymentMethod.PayPal:
                            //check PayPal transaction
                            orderStatus = OrderStatusSync.AwaitingPayment;
                            paypalTransaction = syncOrder.PaypalTran;

                            break;
                        case PaymentMethod.DirectDebit:
                            orderStatus = OrderStatusSync.AwaitingPayment;
                            //orderRepo.TradingTerms = Utility.DetermineTradingTerms(syncOrder.TradingTerms);
                            break;
                            //case PaymentMethod.Voucher:

                            //    break;
                            //case PaymentMethod.Debit:
                            //    break;                       
                    }

                    if (!isTesting)
                    {
                        if (orderStatus == OrderStatusSync.Processed)
                        {
                            orderRepo.Status = orderStatus.GetDisplayName();
                        }
                        else
                        {
                            errorNotifications.Add(String.Format("Sync {2}: Reject the order #{0} with status {1}",
                                syncOrder.PONumber,
                                syncOrder.Status,
                                storeInfo.StoreType.GetDisplayDescription())
                            );
                        }
                    }

                    #endregion

                    if (syncOrder.ExtraInfo != null && syncOrder.ExtraInfo.Count() > 0)
                    {
                        orderRepo.ExtraInfo = syncOrder.ExtraInfo;
                    }

                    breakPoint += ">> Check order item";
                    IEnumerable<string> internalCodes = syncOrder.Orderdetails.Select(od => od.InternalCode).Distinct();
                    Dictionary<string, SKU> checkingProduct = new Dictionary<string, SKU>();

                    if (internalCodes != null && internalCodes.Count() > 0)
                    {
                        checkingProduct = GetSKUs(internalCodes.ToList(), false);
                    }
                    else
                    {
                        errorNotifications.Add(String.Format("Sync #{0}: Internalcode is not exist", syncOrder.PONumber));
                    }

                    breakPoint += ">> Checking product for order detail";
                    #region Creating new order - check and Set order items

                    List<Orderdetail> orderDetails = new List<Orderdetail>();

                    if (checkingProduct.Any() && checkingProduct.Count > 0)
                    {
                        //Check Role Sync order by StoreID
                        bool isOrderProcessingByFF = false;
                        if (storeInfo.RoleIDs.Exists(w => w == SynchRole.OrderProcessingByFF))
                        {
                            isOrderProcessingByFF = syncOrder.Orderdetails.Any(w => w.Personalisation != null && w.Personalisation.Text.Count > 0);
                            if (isOrderProcessingByFF)
                            {
                                orderNotes.Add(new OrderNote()
                                {
                                    Note = String.Format("All order items #{0} have been dispatched from FF Team by sync role '{1}'", syncOrder.PONumber, SynchRole.OrderProcessingByFF.GetDisplayName())
                                });
                            }

                        }

                        foreach (var syncItem in syncOrder.Orderdetails)
                        {
                            if (ValidationHelper.IsValid(syncItem, out validationResult))
                            {
                                Orderdetail orderItem = new Orderdetail();
                                decimal price = 0.0m;
                                decimal tax = 0.0m;
                                decimal taxRate = 0.0m;

                                orderItem.Name = syncItem.Name;
                                orderItem.Qty = syncItem.Qty;
                                orderItem.Comments = !String.IsNullOrEmpty(syncItem.Comments) ? syncItem.Comments : "";

                                tax = syncItem.Tax;
                                taxRate = syncItem.TaxRate;
                                price = syncItem.Price;

                                if (!String.IsNullOrEmpty(syncOrder.Delivery.Country) && !Regex.IsMatch(syncOrder.Delivery.Country, "australia", RegexOptions.IgnoreCase))
                                {
                                    tax = 0.0m;
                                    taxRate = 0.0m;
                                }

                                orderItem.Price = price;
                                orderItem.Tax = tax;
                                orderItem.TaxRate = taxRate;

                                //add on 27/07/2021
                                orderItem.RawData = syncItem.RawData;

                                //add on 01/12/2021 to compare with external shop in the table ItemRawData
                                orderItem.ShopOcdetailID = syncItem.OcdetailID;

                                //IsFF_Item was taken from external shop.
                                //applies from 02/08/2021 from SCF project
                                orderItem.IsFF_Item = syncItem.IsFF_Item;
                                //orderItem.

                                SKU sku = checkingProduct[syncItem.InternalCode];

                                if (sku != null && sku.Id > 0)
                                {
                                    //Get Real product item
                                    orderItem.StockId = sku.VirtualId == 0 ? sku.Id : sku.VirtualId;

                                    orderItem.WarehouseID = (int)syncItem.WarehouseID;

                                    //Set Default Warehouse for order details
                                    if (storeInfo.RoleIDs.Exists(s => s == SynchRole.SetDefaultWH) || syncItem.WarehouseID == 0)
                                    {
                                        orderItem.WarehouseID = sku.PrimaryWarehouse;
                                    }

                                    orderItem.CatalogueId = sku.CatalogueId;
                                    orderItem.Code = sku.InventoryCode;

                                    //Get Inventory Code from Shop to store into order detail code
                                    if (storeInfo.RoleIDs.Exists(s => s == SynchRole.InventoryCodeFromShop))
                                    {
                                        orderItem.Code = syncItem.InventoryCode;
                                    }

                                    //add Personalisation
                                    if (syncItem.Personalisation != null && syncItem.Personalisation.Text.Count > 0)
                                    {
                                        orderItem.Personalisation = syncItem.Personalisation;
                                        //hardcode for old role NSG and AUSKICK to be upgraded from 02/08/2021                                        
                                        if (storeInfo.CatalogueId == CatalogueId.AUSKICK || storeInfo.CatalogueId == CatalogueId.NetSetGo)
                                        {
                                            orderItem.IsFF_Item = true;
                                        }
                                    }

                                    if (isOrderProcessingByFF && !orderItem.IsFF_Item)
                                    {
                                        orderItem.IsFF_Item = true;
                                    }

                                    orderDetails.Add(orderItem);
                                }
                                else
                                {
                                    errorNotifications.Add(String.Format("SKU: {0} incorrect", syncItem.InternalCode));
                                }
                            }
                            else
                            {
                                errorNotifications.AddRange(validationResult.Select(s => s.ErrorMessage));
                            }
                        }
                    }

                    #region Creating new order - Set order only discount
                    breakPoint += ">> Checking discount for order detail";
                    try
                    {
                        if (syncOrder.DiscountAmount > 0.01m)
                        {
                            var discountTaxRate = 0.0m;
                            var discountPrice = 0.0m;
                            var discountTax = 0.0m;

                            //var discountValue = syncOrder.DiscountAmount;
                            //decimal taxRate = 1.0m;

                            if (syncOrder.DiscountTaxRate > 0 || syncOrder.DiscountTax > 0)
                            {
                                discountTaxRate = syncOrder.DiscountTaxRate;
                                //taxRate = Math.Round((discountTaxRate / 100) + 1);
                            }
                            //else if(storeInfo.RoleIDs.Exists(s => s == SynchRole.SetDefaultTax))
                            //{
                            //    taxRate = 1.1m;
                            //}

                            //discountPrice = 1.0m * (discountValue / taxRate);
                            //discountTax = 1.0m * (discountValue - discountPrice);
                            if (syncOrder.DiscountAmount > 0 && syncOrder.DiscountTax > 0)
                            {
                                discountPrice = syncOrder.DiscountAmount;
                                discountTax = syncOrder.DiscountTax;
                                discountTaxRate = syncOrder.DiscountTaxRate;
                            }
                            else
                            {
                                discountPrice = syncOrder.DiscountAmount;
                            }


                            if (discountTaxRate <= 0.0m)
                            {
                                discountTaxRate = discountPrice > 0 ? Math.Round(discountTax / discountPrice * 100, 0) : 10.0m;
                            }

                            //Apply tax for international
                            //if (!String.IsNullOrEmpty(syncOrder.Delivery.Country) 
                            //    && !Regex.IsMatch(syncOrder.Delivery.Country, "australia", RegexOptions.IgnoreCase))
                            //{
                            //    discountPrice = 1.0m * discountValue;
                            //    discountTax = 0.0m;
                            //    discountTaxRate = 0.0m;
                            //}

                            if (Math.Abs(discountPrice) > 0.01m)
                            {
                                discountPrice = Math.Abs(discountPrice) * -1;
                                discountTax = Math.Abs(discountTax) * -1;
                                var discount_item = new Orderdetail()
                                {
                                    Name = "Discounts",
                                    Price = discountPrice,
                                    Tax = discountTax,
                                    TaxRate = discountTaxRate,
                                    Qty = 1,
                                    StockId = 33537,
                                    Code = "000.100DSC",
                                    Comments = "",
                                    CatalogueId = syncOrder.CatalogueID,
                                    WarehouseID = 1
                                };
                                orderDetails.Add(discount_item);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        errorNotifications.Add(String.Format("Discount Error: {0}", ex.Message));
                        _loggerWindows.LogError(ex, "{Message}", ex.Message);
                    }
                    #endregion

                    #region Creating new order - Set order freight
                    breakPoint += ">> Checking Freight & Handling for order detail";
                    try
                    {
                        orderDetails.Add(new Orderdetail()
                        {
                            CatalogueId = catalogue.Id,
                            Code = "000.111",
                            Comments = "",
                            Name = "Freight & Handling",
                            Price = syncOrder.FreightFee,
                            Tax = syncOrder.FreightTax,
                            TaxRate = syncOrder.FreightFee > 0 ? Math.Round(syncOrder.FreightTax / syncOrder.FreightFee * 100, 0) : 10,
                            StockId = 8760,
                            Qty = 1,
                            WarehouseID = 1
                        });
                    }
                    catch (Exception ex)
                    {
                        errorNotifications.Add(String.Format("Freight & Handling Error: {0}", ex.Message));
                        _loggerWindows.LogError(ex, "{Message}", ex.Message);
                    }
                    #endregion

                    orderRepo.Orderdetails = orderDetails;

                    #endregion                          

                    breakPoint += ">> Set on hold status";
                    #region Creating new order - Set on hold status
                    if (isTesting)
                    {
                        orderRepo.Onhold = true;
                        orderRepo.ToBeInvoiced = false; //makes cancelling tests a bit easier.
                        //orderRepo.Status = OrderStatus.AwaitingPayment.GetDisplayName();
                        //orderRepo.TradingTerms = TradingTerms.PREPAYMENT;
                        orderNotes.Add(new OrderNote()
                        {
                            Note = String.Format("Test {1} order .. do not dispatch .. #{0}", syncOrder.PONumber, storeInfo.CatalogueName)
                        });
                    }
                    #endregion

                    breakPoint += ">> Creating new order";
                    if (errorNotifications.Count <= 0)
                    {
                        //breakPoint += ">> Utility.SaveSyncOrderInfo";
                        //Utility.SaveSyncOrderInfo(syncOrder, storeInfo.StoreType, orderRepo.PONumber);
                        breakPoint += ">> orderRepo.Save";
                        //Calculate sync number OnOrder_Avaiable (inventory.tpf.com.au)
                        //Calculate number OnStock_OnOrder_Avaiable (table Product)
                        //Insert to table Tpfsystem.dbo.orderconf : ocid = TPFOrderID
                        bool isSuccess = SaveOrderRepository(orderRepo);
                        if (isSuccess)
                        {
                            result = orderRepo.OrderNumber;
                            breakPoint = String.Format("Add credit card transaction order #{0}", orderRepo.PONumber);

                            if (orderRepo.PayOption == PaymentMethod.CreditCard && orderRepo.OrderTotal > 0 && !isTesting)
                            {
                                creditCard.OrderNumber = orderRepo.OrderNumber.ToString();
                                if (!ValidationHelper.IsValid(creditCard, out validationResult))
                                {
                                    errorNotifications.AddRange(validationResult.Select(s => s.ErrorMessage));
                                }

                                bool isAddCreditcardTrans = AddCreditcardTransaction(creditCard);
                                if (!isAddCreditcardTrans || errorNotifications.Count > 0)
                                {
                                    string subject = String.Format("Order#{0} without transaction ", orderRepo.PONumber);
                                }
                            }
                            else if (orderRepo.PayOption == PaymentMethod.PayPal && orderRepo.OrderTotal > 0 && !isTesting)
                            {
                                paypalTransaction.OrderNumber = orderRepo.OrderNumber.ToString();
                                if (!ValidationHelper.IsValid(paypalTransaction, out validationResult))
                                {
                                    errorNotifications.AddRange(validationResult.Select(s => s.ErrorMessage));
                                }
                                bool isAddpaypalTran = AddPaypalTransaction(paypalTransaction);
                                if (!isAddpaypalTran || errorNotifications.Count > 0)
                                {
                                    string subject = String.Format("Order#{0} without transaction ", orderRepo.PONumber);
                                }
                                else
                                {
                                    //orderRepo.up
                                    ChangeOrderStatus(orderRepo.OrderNumber, OrderStatusSync.Processed);
                                }
                            }

                            breakPoint += ">> orderRepo.AddOrderSyncTracking";
                            List<OrderSyncTrackingSignalR> trackings = new List<OrderSyncTrackingSignalR>();
                            trackings.Add(new OrderSyncTrackingSignalR()
                            {
                                TPFOrderID = orderRepo.OrderNumber,
                                PONumber = orderRepo.PONumber,
                                OrderStatus = orderRepo.Status,
                                StoreId = storeInfo.StoreSiteId,
                                PendingDuration = isTesting ? 12 : 0, //Duration 12h for cancel
                                RawData = "",
                                SyncStatus = isTesting ? SyncStatus.Testing : SyncStatus.Pending,
                            });
                            //Update table WebOrder : TPFOrderID value, SyncStatus=Synchronized, TPFOrrderSyncDate
                            //Update table OnlineSyncData.dbo.OrderSyncTracking : TPFOrderID value, OrderStatus=Processed, SyncStatus=1, SyncDelStatus=1
                            //Insert in view OnlineSyncData.[dbo].[v_OrderTracking] with POnumber : TPFOrderID value, SyncStatus=1, SyncDelStatus=1
                            AddOrderSyncTrackingExtent(trackings);

                            breakPoint += ">> orderRepo.AddInternalOrderNotes";
                            AddInternalOrderNotes(orderRepo.OrderNumber, orderNotes);

                            breakPoint += ">> Request Sync Stock after create order";
                            if (internalCodes != null && internalCodes.Count() > 0)
                            {
                                //Update table OnlineSyncData.dbo.InventorySync : SyncStatus
                                SyncStockByOrdernumber(result);
                            }
                        }
                    }
                    else
                    {
                        _loggerWindows.LogCritical("CreateOrderForWLB Error: {error}", GroupLog.SyncRepository, syncOrder.PONumber);
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "Error at CreateOrderForWLB : {Message}", ex.Message);
            }

        EndAction:

            return result;
        }

        public OrderStatusTracking GetOrderStatusTracking(string poNumber)
        {
            OrderStatusTracking result = new OrderStatusTracking();
            string breakPoint = "Start";

            try
            {
                breakPoint = "build parameters";
                var parameters = new[]
                {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "poNumber", DbType = DbType.String, Value= poNumber, Size = 20 }
                };

                StringBuilder sqlQuery = new StringBuilder();
                sqlQuery.Append("SELECT Id, TpfOrderId as TPFOrderID, PoNumber as PONumber, OrderStatus, DelStatus AS DeliveryStatus, SyncStatus, SyncDelStatus, PendingDuration, CreatedDate, RGuid ");
                sqlQuery.Append("FROM [dbo].[v_OrderTracking] ");
                sqlQuery.Append("WHERE poNumber=@poNumber;");

                breakPoint = "connection database to get data";
                using (var command = _dbOnlineSyncDataContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery.ToString();
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    _dbOnlineSyncDataContext.Database.OpenConnection();

                    DataTable dataTable = new DataTable();
                    using (var dt = command.ExecuteReader())
                    {
                        dataTable.Load(dt);
                    }
                    IEnumerable<OrderStatusTracking> _query = dataTable.ToIEnumerable<OrderStatusTracking>();
                    result = _query.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return result;
        }

        private CatalogueSignalR GetCatalogueById(int categoryId)
        {
            string breakPoint = "Start";
            CatalogueSignalR result = new CatalogueSignalR();

            try
            {
                breakPoint = "build parameters";
                var parameters = new[]
                {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "CatStatus", DbType = DbType.String, Value= "yes", Size = 20 },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "categoryId", DbType = DbType.Int32, Value= categoryId }
                };
                breakPoint = "connection database to get data";
                string sqlQuery = "SELECT * FROM [dbo].[v_Catalogue] WHERE CatStatus = @CatStatus and CatalogueId=@categoryId; ";
                using (var command = _dbCsversion1Context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    _dbCsversion1Context.Database.OpenConnection();

                    DataTable dataTable = new DataTable();
                    using (var dt = command.ExecuteReader())
                    {
                        dataTable.Load(dt);
                    }
                    IEnumerable<CatalogueView> _query = dataTable.ToIEnumerable<CatalogueView>();

                    CatalogueView cat = _query.FirstOrDefault();
                    breakPoint = "convert from CatalogueView to object Catalogue";
                    if (cat != null && cat.CatalogueId > 0)
                    {
                        result = new CatalogueSignalR()
                        {
                            Id = (int)cat.CatalogueId,
                            Name = cat.CatalogueName,
                            CashClientId = (int)(cat.ClientID),
                            HandledBy = (int)(cat.StaffId),
                            MagentoKey = cat.MagentoKey,
                            Active = string.Compare(cat.CatStatus, "yes", true) == 0,
                            Currency = cat.Currency,
                            TaxRate = cat.TaxRate == 0 ? 10 : cat.TaxRate,
                        };
                    }
                }

            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="internalcodes">List Internal Codes Need to Get Stock</param>
        /// <param name="isSync">Need to get without the status sync</param>
        /// <returns></returns>
        private Dictionary<string, SKU> GetSKUs(IEnumerable<string> internalcodes, bool? isSync)
        {
            string breakPoint = "Start";
            Dictionary<string, SKU> result = new Dictionary<string, SKU>();
            var toSync = isSync ?? false;
            Dictionary<string, string> dataLog = new Dictionary<string, string>();
            dataLog.Add("Function", "GetSKUs");

            try
            {
                breakPoint = "Convert internalcodes to prodetailIDs";
                dataLog.Add("Internal Codes", string.Join(",", internalcodes));
                List<int> prodetailIds = new List<int>();

                if (internalcodes == null) goto result;
                else
                {
                    internalcodes = internalcodes.Distinct().ToList();
                }

                foreach (var code in internalcodes)
                {
                    int prodetailId = 0;
                    try
                    {
                        breakPoint = String.Format("Start Convert internalcode: {0}", code);

                        if (Utility.ConvertInternalCodeToProdetailId(code, out prodetailId))
                        {
                            prodetailIds.Add(prodetailId);
                        }
                    }
                    catch (Exception ex)
                    {
                        _loggerWindows.LogError(ex, "{Message}", ex.Message);
                    }
                }

                if (prodetailIds.Count > 0)
                {
                    breakPoint = "connection database to get data";
                    
                    string sqlQuery = string.Empty;
                    List<Models.MPlusSyncOrder.ProductInfo> products;

                    sqlQuery = "SELECT * FROM [dbo].[v_API_ProductInfo] WHERE [prodetailID] IN (@prodetailIDs) ";
                    string listProdetailIDs = "";
                    prodetailIds.ForEach(pr =>
                    {
                        listProdetailIDs += pr + ",";
                    });
                    listProdetailIDs = listProdetailIDs.TrimEnd(',');
                    var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "prodetailIDs", DbType = DbType.String, Value = listProdetailIDs }
                    };

                    if (isSync != null && isSync.Value)
                    {
                        sqlQuery += String.Format("AND [toSync] = 1 ");
                    }
                    dataLog.Add("SQL Query: ", sqlQuery);

                    dataLog.Add("ProdetailIDs", string.Join(",", prodetailIds));

                    using (var command = _dbCsversion1Context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddRange(parameters);

                        _dbCsversion1Context.Database.OpenConnection();

                        breakPoint = "Get ProductInfo from v_API_ProductInfo";

                        DataTable dataTable = new DataTable();
                        using (var dt = command.ExecuteReader())
                        {
                            dataTable.Load(dt);
                        }
                        products = ConvertDataTable<Models.MPlusSyncOrder.ProductInfo>(dataTable);
                    }

                    if (products.Count() > 0)
                    {
                        //build SKUs
                        //IEnumerable<SKU> SKUs = products.Select(obj => new SKU()
                        //{
                        //    Id = (int)obj.ProdetailID,
                        //    ProId = (int)obj.ProID,
                        //    VirtualId = (int)obj.VirtualRefID,
                        //    CatalogueId = obj.CatalogueID,
                        //    InternalCode = obj.Internalcode,
                        //    Barcode = obj.Barcode,
                        //    InventoryCode = obj.ProdetailCode,
                        //    Name = obj.ProdName,
                        //    Size = obj.ProdetailSize,
                        //    Weight = obj.Weight,
                        //    CanBackOrder = obj.Bo_Status == "y", //sync pd
                        //    InventoryStatus = obj.InventoryStatusText.ToLower(),
                        //    PrimaryWarehouse = obj.Pd_Whid, //sync pd
                        //    GlobalOnhand = (int)obj.ProdetailStock, //sync pd
                        //    GlobalOnorder = (int)obj.CustOrder, //sync pd
                        //    Onhand = new Dictionary<int, int>(),
                        //    Available = new Dictionary<int, int>(),
                        //    Onorder = new Dictionary<int, int>(),
                        //    LastSync = obj.LastTurnOnToSync ?? DateTime.MinValue,
                        //    IsKitDynamic = obj.isDynamicKit == 1
                        //});
                        List<SKU> SKUs = new List<SKU>();
                        products.ForEach(obj =>
                        {
                            SKU skuItem = new SKU();
                            skuItem.Id = (int)obj.ProdetailID;
                            skuItem.ProId = (int)obj.ProID;
                            skuItem.VirtualId = (int)obj.VirtualRefID;
                            skuItem.CatalogueId = obj.CatalogueID;
                            skuItem.InternalCode = obj.Internalcode;
                            skuItem.Barcode = obj.Barcode;
                            skuItem.InventoryCode = obj.ProdetailCode;
                            skuItem.Name = obj.ProdName;
                            skuItem.Size = obj.ProdetailSize;
                            skuItem.Weight = obj.Weight;
                            skuItem.CanBackOrder = obj.Bo_Status == "y";//sync pd
                            skuItem.InventoryStatus = obj.InventoryStatusText.ToLower();
                            skuItem.PrimaryWarehouse = obj.Pd_Whid;//sync pd
                            skuItem.GlobalOnhand = long.Parse(obj.ProdetailStock.ToString());//sync pd
                            skuItem.GlobalOnorder = long.Parse(obj.CustOrder.ToString());//sync pd
                            skuItem.Onhand = new Dictionary<int, long>();
                            skuItem.Available = new Dictionary<int, long>();
                            skuItem.Onorder = new Dictionary<int, long>();
                            skuItem.LastSync = obj.LastTurnOnToSync ?? DateTime.MinValue;
                            skuItem.IsKitDynamic = obj.isDynamicKit == 1;

                            SKUs.Add(skuItem);
                        });

                        //get product qty
                        var simpleProdetaiIDs = products.Where(s => s.VirtualRefID.Equals(0)).Select(s => s.ProdetailID).ToList();
                        var virtualProdetailIDs = products.Where(s => s.VirtualRefID > 0).Select(s => s.VirtualRefID).ToList();
                        var productQties = GetProductQties(simpleProdetaiIDs.Union(virtualProdetailIDs)).ToList();

                        //get packProduct
                        var kitPackProduct = products.Where(s => s.isDynamicKit == 1).ToList();
                        breakPoint = "Checking stock";
                        foreach (string internalcode in internalcodes)
                        {
                            SKU skuItem = SKUs.FirstOrDefault(f => f.InternalCode == internalcode);

                            if (skuItem != null)
                            {
                                breakPoint = String.Format("Checking stock of InternalCode #{0}", skuItem.InternalCode);
                                //Stock in every WH
                                switch (skuItem.VirtualId)
                                {
                                    case 0: //Stock of simple product
                                        breakPoint = String.Format("Checking Stock of simple product of InternalCode #{0}", skuItem.InternalCode);
                                        var stockQty = productQties.Where(w => w.ProdetailId == skuItem.Id);
                                        if (stockQty != null && stockQty.Count() > 0)
                                        {
                                            foreach (var item in stockQty)
                                            {
                                                if (item.OnHand < 0)
                                                {
                                                    item.OnHand = 0;
                                                }

                                                if (item.Available < 0)
                                                {
                                                    item.Available = 0;
                                                }

                                                if (item.OnCustOrder < 0)
                                                {
                                                    item.OnCustOrder = 0;
                                                }

                                                skuItem.Onhand.Add(item.WhId, item.OnHand);
                                                skuItem.Available.Add(item.WhId, item.Available); //sync pq
                                                skuItem.Onorder.Add(item.WhId, item.OnCustOrder);
                                            }
                                        }
                                        else
                                        {
                                            skuItem.Onhand.Add(skuItem.PrimaryWarehouse, 0);
                                            skuItem.Available.Add(skuItem.PrimaryWarehouse, 0); //sync pq
                                            skuItem.Onorder.Add(skuItem.PrimaryWarehouse, 0);
                                        }
                                        break;
                                    default: //Stock of virtual product
                                        breakPoint = String.Format("Checking Stock of virtual product of InternalCode #{0}", skuItem.InternalCode);
                                        var stockQtyVirtual = productQties.Where(w => w.ProdetailId == skuItem.VirtualId);
                                        if (stockQtyVirtual != null && stockQtyVirtual.Count() > 0)
                                        {
                                            foreach (var item in stockQtyVirtual)
                                            {
                                                if (item.OnHand < 0)
                                                {
                                                    item.OnHand = 0;
                                                }

                                                if (item.Available < 0)
                                                {
                                                    item.Available = 0;
                                                }

                                                if (item.OnCustOrder < 0)
                                                {
                                                    item.OnCustOrder = 0;
                                                }

                                                skuItem.Onhand.Add(item.WhId, item.OnHand);
                                                skuItem.Available.Add(item.WhId, item.Available); //sync pq
                                                skuItem.Onorder.Add(item.WhId, item.OnCustOrder);
                                            }
                                        }
                                        else
                                        {
                                            skuItem.Onhand.Add(skuItem.PrimaryWarehouse, 0);
                                            skuItem.Available.Add(skuItem.PrimaryWarehouse, 0); //sync pq
                                            skuItem.Onorder.Add(skuItem.PrimaryWarehouse, 0);
                                        }
                                        break;
                                }

                                //Build Kit Items
                                if (skuItem.IsKitDynamic)
                                {
                                    breakPoint = String.Format("Kit Items of InternalCode #{0}", skuItem.InternalCode);
                                    var kitItems = GetKitItems(skuItem.InternalCode);
                                    skuItem.KitItems = kitItems != null && kitItems.Count() > 0 ? kitItems.ToList() : null;
                                }

                                result.Add(internalcode.Trim(), skuItem);
                            }
                            else
                            {
                                result.Add(internalcode.Trim(), null);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

        result:
            return result;
        }

        private List<ProductQtySignalR> GetProductQties(IEnumerable<long> prodetailIDs)
        {
            List<ProductQtySignalR> result = null;
            string breakPoint = "Start";

            try
            {
                if (prodetailIDs.Count() > 0)
                {
                    breakPoint = "connection database to get data";
                    
                    string sqlQuery = "SELECT * FROM [dbo].[product_qty] WHERE [prodetailid] IN (@prodetailIDs) ";
                    string listProdetailIDs = "";
                    prodetailIDs.ToList().ForEach(p =>
                    {
                        listProdetailIDs += p + ",";
                    });
                    listProdetailIDs = listProdetailIDs.TrimEnd(',');
                    var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "prodetailIDs", Value= listProdetailIDs }
                    };

                    using (var command = _dbCsversion1Context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddRange(parameters);

                        _dbCsversion1Context.Database.OpenConnection();

                        breakPoint = "Get ProductInfo from v_API_ProductInfo";
                        DataTable dataTable = new DataTable();
                        using (var dt = command.ExecuteReader())
                        {
                            dataTable.Load(dt);
                        }
                        result = ConvertDataTable<ProductQtySignalR>(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return result;
        }

        private List<SKU> GetKitItems(string internalCode)
        {
            List<SKU> result = new List<SKU>();
            //get ProPack
            string breakPoint = "Start";

            try
            {
                if (!String.IsNullOrEmpty(internalCode) && !String.IsNullOrWhiteSpace(internalCode))
                {
                    breakPoint = "connection database to get data";
                    
                    string sqlQuery = "SELECT * FROM [dbo].[v_API_ProPack] WHERE [internalcode]=@InternalCode and [pkstatus]=@pkStatus ";
                    //IEnumerable<API_ProPack> proPacks = null;
                    List<API_ProPack> proPacks = new List<API_ProPack>();
                    var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "InternalCode", DbType = DbType.String, Value= internalCode, Size = 50 },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "pkStatus", DbType = DbType.String, Value= "y", Size = 20 }
                    };

                    using (var command = _dbCsversion1Context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddRange(parameters);

                        _dbCsversion1Context.Database.OpenConnection();

                        DataTable dataTable = new DataTable();
                        using (var dt = command.ExecuteReader())
                        {
                            dataTable.Load(dt);
                        }
                        proPacks = ConvertDataTable<API_ProPack>(dataTable);

                        if (proPacks.Count() > 0)
                        {
                            foreach (var kit in proPacks)
                            {
                                int prodetailId = 0;
                                if (Utility.ConvertInternalCodeToProdetailId(kit.kitInternalCode, out prodetailId))
                                {
                                    var kitSKU = GetSKU(prodetailId, null);
                                    if (kitSKU != null)
                                    {
                                        kitSKU.KitQty = kit.pkQty;
                                        result.Add(kitSKU);
                                    }
                                }
                            }
                        }
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return null;
        }

        private SKU GetSKU(int prodetailID, bool? isSync)
        {
            string breakPoint = "Start";

            try
            {
                IEnumerable<Models.MPlusSyncOrder.ProductInfo> stock = null;

                
                string sqlQuery = "SELECT * FROM [dbo].[v_API_ProductInfo] WHERE [prodetailID]=@prodetailID ";
                var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "prodetailID", DbType = DbType.Int32, Value = prodetailID }
                    };

                using (var command = _dbCsversion1Context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    _dbCsversion1Context.Database.OpenConnection();

                    DataTable dataTable = new DataTable();
                    using (var dt = command.ExecuteReader())
                    {
                        dataTable.Load(dt);
                    }
                    stock = dataTable.ToIEnumerable<Models.MPlusSyncOrder.ProductInfo>();
                    //stock = (IEnumerable<Models.MPlusSyncOrder.ProductInfo>)command.ExecuteReader();
                }

                if (isSync != null)
                {
                    var toSync = isSync == true;
                    stock = stock.Where(n => n.ToSync == toSync);
                }

                var sku = PackageSKU(stock.FirstOrDefault());

                return sku;
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return null;
        }

        private SKU PackageSKU(Models.MPlusSyncOrder.ProductInfo stock)
        {
            SKU sku = null;
            string breakPoint = "Start";

            try
            {
                if (stock != null)
                {
                    breakPoint = "Convert to Json to log";

                    sku = new SKU()
                    {
                        Id = (int)stock.ProdetailID,
                        ProId = stock.ProID,
                        VirtualId = (int)stock.VirtualRefID,
                        CatalogueId = stock.CatalogueID,
                        InternalCode = stock.Internalcode ?? "",
                        Barcode = stock.Barcode ?? "",
                        InventoryCode = stock.ProdetailCode ?? "",
                        Name = stock.ProdName ?? "",
                        Size = stock.ProdetailSize ?? "",
                        Weight = stock.Weight,
                        CanBackOrder = stock.Bo_Status == "y",
                        InventoryStatus = stock.InventoryStatusText.ToLower(),
                        PrimaryWarehouse = stock.Pd_Whid,
                        LastSync = stock.LastTurnOnToSync ?? DateTime.MinValue,
                        IsKitDynamic = stock.isDynamicKit == 1,
                        Available = new Dictionary<int, long>() {
                                    {0, (long)(stock.Available) }
                                },
                        Onhand = new Dictionary<int, long>() {
                                    {0, (long)(stock.ProdetailStock) }
                                },
                        Onorder = new Dictionary<int, long>() {
                                    {0, (long)(stock.CustOrder) }
                                },
                        GlobalOnhand = (long)(stock.ProdetailStock),
                        GlobalOnorder = (long)(stock.CustOrder),
                        KitItems = new List<SKU>(),
                        //GlobalAvailable = (int)stock.Available,
                        //KitQty = 0
                    };

                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return sku;
        }

        private bool SaveOrderRepository(OrderRepository order)
        {
            bool result = false;
            string breakPoint = "Start";
            try
            {
                int OrderNumber = 0;
                breakPoint = "Convert Order Oject To XML";
                string orderItems = this.OrderRepositoryToXML(order);

                if (String.IsNullOrEmpty(orderItems))
                {
                    goto finallyStep;
                }

                string sqlQuery = "order_create_v2_SyncRealtime_New";
                var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "lineitems", Value = orderItems },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "ocid", DbType = DbType.Int32, Direction = ParameterDirection.Output }
                    };
                breakPoint = "connection database to create order";

                using (var command = _dbTpfsystemContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);

                    _dbTpfsystemContext.Database.OpenConnection();

                    using (var _query = command.ExecuteReader())
                    {
                        OrderNumber = (int)parameters[1].Value;
                    }
                    if (OrderNumber > 0)
                    {
                        result = true;
                        order.OrderNumber = OrderNumber;
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

        finallyStep:
            return result;
        }

        private string OrderRepositoryToXML(OrderRepository order)
        {
            string breakPoint = "Start";

            try
            {
                var doc = new XDocument(new XDeclaration("1.0", "utf-8", "true"));
                breakPoint = "Create the XML Order";
                var root = new XElement("order",
                                new XElement("orderdetails",
                                    new XElement("catalogueID", order.CatalogueID),
                                    new XElement("costcentre", ""),
                                    new XElement("currency", order.Currency),
                                    new XElement("deldetails", order.DeliveryNotesToWarehouse),
                                    new XElement("deliveryDate", order.DeliveryDate.ToString("yyyy-MM-dd HH:mm:ss")),
                                    new XElement("disclaimer", order.Disclaimer ?? ""),
                                    new XElement("enteredby", order.Enteredby.ToString()),
                                    new XElement("exchangerate", order.Exchangerate),
                                    new XElement("FOB", order.FreeOnBoard ? "yes" : "no"),
                                    new XElement("handledby", order.HandledBy),
                                    new XElement("jobstatus", "closed"),
                                    new XElement("ordertotal", order.OrderTotal),
                                    new XElement("ordertotalexc", order.OrderTotalExc),
                                    new XElement("profileID", "0"),
                                    new XElement("onlineOrder", order.Enteredby == 332 ? "yes" : "no"),
                                    new XElement("order_group", "External"),
                                    new XElement("refType", order.RefType ?? ""), // update on 24/07/2019 to update Type to ref from external shop
                                    new XElement("position", order.Position ?? ""), // Add position for FF Team processing Shipping Type on 13-08-2021
                                    new XElement("payoption", order.PayOption),
                                    new XElement("processedby", "332"),
                                    new XElement("onhold", order.Onhold ? "1" : "0"),
                                    new XElement("ponumber", order.PONumber ?? ""),
                                    new XElement("promotionName", order.PromotionName),
                                    new XElement("status", order.Status),
                                    new XElement("sendwithgoods", order.SendInvoiceWithGoods ? "yes" : "no"),
                                    new XElement("tobeinvoiced", order.ToBeInvoiced ? "yes" : "no"),
                                    new XElement("tradeterms", TradingTerms.DAYS_30),
                                    new XElement("vendorno", order.VendorNumber ?? ""),
                                    new XElement("trackingcode", order.Trackingcode ?? ""),
                                    new XElement("ismagento", order.IsMagento),
                                    new XElement("webstoreno", order.WebstoreNumber ?? ""),
                                    new XElement("importref", order.Importref ?? "") //add discount code for magento 1 and magento 2
                                ),
                                new XElement("addresses",
                                    new XElement("contact",
                                        new XElement("companyname", order.Contact.CompanyName ?? ""),
                                        new XElement("fname", order.Contact.FirstName ?? ""),
                                        new XElement("lname", order.Contact.LastName ?? ""),
                                        new XElement("address", (order.Contact.Address1 ?? "") + ", " + (order.Contact.Address2 ?? "")),
                                        new XElement("suburb", order.Contact.Suburb ?? ""),
                                        new XElement("state", order.Contact.State ?? ""),
                                        new XElement("country", order.Contact.Country ?? ""),
                                        new XElement("postcode", order.Contact.Postcode ?? ""),
                                        new XElement("phone", order.Contact.Phone ?? ""),
                                        new XElement("email", order.Contact.Email ?? ""),
                                        new XElement("clientid", order.ClientID)
                                    ),
                                    new XElement("billing",
                                        new XElement("attention", order.Billing.Attention ?? ""),
                                        new XElement("companyname", order.Billing.CompanyName ?? ""),
                                        new XElement("address", (order.Billing.Address1 ?? "") + ", " + (order.Billing.Address2 ?? "")),
                                        new XElement("suburb", order.Billing.Suburb ?? ""),
                                        new XElement("state", order.Billing.State ?? ""),
                                        new XElement("country", order.Billing.Country ?? ""),
                                        new XElement("postcode", order.Billing.Postcode ?? ""),
                                        new XElement("phone", order.Billing.Phone ?? ""),
                                        new XElement("email", order.Billing.Email ?? "")
                                    ),
                                    new XElement("delivery",
                                        new XElement("attention", order.Delivery.Attention ?? ""),
                                        new XElement("fname", order.Delivery.FirstName ?? ""),
                                        new XElement("lname", order.Delivery.LastName ?? ""),
                                        new XElement("companyname", order.Delivery.CompanyName ?? ""),
                                        new XElement("address", (order.Delivery.Address1 ?? "") + ", " + (order.Delivery.Address2 ?? "")),
                                        new XElement("suburb", order.Delivery.Suburb ?? ""),
                                        new XElement("state", order.Delivery.State ?? ""),
                                        new XElement("country", order.Delivery.Country ?? ""),
                                        new XElement("postcode", order.Delivery.Postcode ?? ""),
                                        new XElement("phone", order.Delivery.Phone ?? ""),
                                        new XElement("email", order.Delivery.Email ?? "")
                                    ),
                                    new XElement("extrainfo",
                                        from e in order.ExtraInfo
                                        select new XElement("field", e.Value, new XAttribute("name", e.Key))
                                    )
                                ),
                                from it in order.Orderdetails
                                select new XElement("item",
                                    new XElement("ocdetailcode", it.Code ?? ""),
                                    new XElement("ocdetailname", it.Name ?? ""),
                                    new XElement("ocdetailqty", it.Qty),
                                    new XElement("ocdetailprice", it.Price / order.Exchangerate),
                                    new XElement("ocdetailgst", it.Tax / order.Exchangerate),
                                    new XElement("pricein", (it.Price + it.Tax) / order.Exchangerate),
                                    new XElement("rateTax", it.TaxRate),
                                    new XElement("PriceExTax", it.Price),
                                    new XElement("PriceInTax", (it.Tax + it.Price)),
                                    new XElement("occomments", it.Comments ?? ""),
                                    new XElement("itemtype", "cpc"),
                                    new XElement("cpcprodetailcode", it.StockId),
                                    new XElement("whid", it.WarehouseID),
                                    new XElement("itemCatalogueID", it.CatalogueId),
                                    new XElement("linenumber", 1 + order.Orderdetails.IndexOf(it)),
                                    new XElement("qtyAvailable", it.Qty),
                                    new XElement("qtyBackOrder", 0),
                                    new XElement("IsFF_Item", it.IsFF_Item),
                                    new XElement("rawdata", it.RawData ?? ""),
                                    new XElement("shopOCDetailID", it.ShopOcdetailID),
                                    new XElement("isPersonalised", it.Personalisation == null ? 0 : 1),
                                    it.Personalisation == null ? null : new XElement("personalisation",
                                        new XElement("type", it.Personalisation.Type ?? ""),
                                        new XElement("style", it.Personalisation.Style),
                                        new XElement("string0", it.Personalisation.Text.Count() >= 1 ? it.Personalisation.Text.ElementAt(0) : ""),
                                        new XElement("string1", it.Personalisation.Text.Count() >= 2 ? it.Personalisation.Text.ElementAt(1) : ""),
                                        new XElement("string2", it.Personalisation.Text.Count() >= 3 ? it.Personalisation.Text.ElementAt(2) : ""),
                                        new XElement("string3", it.Personalisation.Text.Count() >= 4 ? it.Personalisation.Text.ElementAt(3) : ""),
                                        new XElement("string4", it.Personalisation.Text.Count() >= 5 ? it.Personalisation.Text.ElementAt(4) : ""),
                                        new XElement("string5", it.Personalisation.Text.Count() >= 6 ? it.Personalisation.Text.ElementAt(5) : "")
                                    ),
                                    (it.ExtraInfo == null || it.ExtraInfo.Count() == 0) ? null : (from addinfo in it.ExtraInfo
                                                                                                  select new XElement("ExtraItemInfo",
                                                                                                            new XElement("orderdetaillinenumber", 1 + order.Orderdetails.IndexOf(it)),
                                                                                                            new XElement("index", 1 + it.ExtraInfo.IndexOf(addinfo)),
                                                                                                            new XElement("title", addinfo.Title ?? ""),
                                                                                                            new XElement("companyname", addinfo.Companyname ?? ""),
                                                                                                            new XElement("memberNumber", addinfo.MemberNumber ?? ""),
                                                                                                            new XElement("discountcode", addinfo.DiscountCode ?? ""),
                                                                                                            new XElement("fname", addinfo.Fname ?? ""),
                                                                                                            new XElement("lname", addinfo.Lname ?? ""),
                                                                                                            new XElement("address", addinfo.Address ?? ""),
                                                                                                            new XElement("city", addinfo.City ?? ""),
                                                                                                            new XElement("state", addinfo.State ?? ""),
                                                                                                            new XElement("postcode", addinfo.Postcode ?? ""),
                                                                                                            new XElement("phone", addinfo.Phone ?? ""),
                                                                                                            new XElement("mobile", addinfo.Mobile ?? ""),
                                                                                                            new XElement("email", addinfo.Email ?? ""),
                                                                                                            new XElement("gender", addinfo.Gender ?? ""),
                                                                                                            new XElement("emergencycontact", addinfo.EmergencyContact ?? ""),
                                                                                                            new XElement("emergencyphone", addinfo.EmergencyPhone ?? ""),
                                                                                                            new XElement("emergencycontact2", addinfo.EmergencyContact2 ?? ""),
                                                                                                            new XElement("travelmode", addinfo.TravelMode ?? ""),
                                                                                                            new XElement("itemcode", addinfo.ItemCode),
                                                                                                            new XElement("reporttoclub", addinfo.ReportToClub ? "1" : "0"),
                                                                                                            new XElement("dietaryreq", addinfo.DietaryRequirements ?? ""),
                                                                                                            new XElement("physicalcon", addinfo.PhysicalCondition),
                                                                                                            new XElement("allergies", addinfo.Allergies),
                                                                                                            new XElement("event", addinfo.Event ?? ""),
                                                                                                            new XElement("dob", addinfo.DOB == null ? "" : (((DateTime)(addinfo.DOB)).ToString("yyyy-MM-dd HH:mm:ss")))
                                                                                                        )
                                                                                                )
                                )
                            );

                doc.AddFirst(root);
                breakPoint = "Convert xml to string";
                return doc.ToString();
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return string.Empty;
        }

        private bool AddCreditcardTransaction(CreditCardTransaction transactions)
        {
            bool result = false;
            string breakPoint = "Start";

            try
            {
                breakPoint = "tbl OrderTransaction";
                DataTable tblOrderTransaction = new DataTable();
                tblOrderTransaction.Columns.AddRange(new DataColumn[18] {
                    new DataColumn("PayDate", typeof(DateTime)), //1
                    new DataColumn("PayFrom",typeof(string)),//2
                    new DataColumn("Customer",typeof(string)),//3
                    new DataColumn("CustomerNo",typeof(string)),//4
                    new DataColumn("CustomerEmail",typeof(string)),//5
                    new DataColumn("OrderNumber",typeof(string)),//6
                    new DataColumn("TranType",typeof(string)),//7
                    new DataColumn("CardType",typeof(string)),//8
                    new DataColumn("MMexp",typeof(string)),//9
                    new DataColumn("YYexp",typeof(string)),//10
                    new DataColumn("Amount",typeof(string)),//11
                    new DataColumn("Currency",typeof(string)),//12
                    new DataColumn("ResponseCode",typeof(string)),//13
                    new DataColumn("ResponseText",typeof(string)),//14
                    new DataColumn("TxnReference",typeof(string)),//15
                    new DataColumn("ProcessedBy",typeof(string)),//16
                    new DataColumn("CardNo",typeof(string)),//17
                    new DataColumn("Bank",typeof(string)),//18
                });

                tblOrderTransaction.Rows.Add(
                    transactions.PayDate.Value, //1
                    transactions.PromotionName,//2
                    transactions.CustomerName,//3
                    transactions.ClientId.ToString(),//4
                    transactions.CustomerEmail,//5
                    transactions.OrderNumber,//6
                    "Purchase",//7
                    transactions.CardType,//8
                    transactions.ExpiryMonth,//9
                    transactions.ExpiryYear,//10
                    transactions.Amount.ToString(),//11
                    transactions.Currency,//12
                    transactions.ResponseCode,//13
                    transactions.ResponseText,//14
                    transactions.TxnReference,//15
                    transactions.ProcessedBy,//16
                    transactions.CardNumber.Length > 4 ? transactions.CardNumber.Substring(0, 4) : transactions.CardNumber,//17
                    transactions.Bank.Length > 3 ? transactions.Bank.Substring(0, 3) : transactions.Bank //18
                );

                breakPoint = "Parameters";
                var parameters = new DynamicParameters();
                parameters.Add("@CreditcardTransactions", tblOrderTransaction.AsTableValuedParameter("dbo.UDT_CreditCardTransaction"));
                parameters.Add("@MessageDisplay", dbType: DbType.String, direction: ParameterDirection.Output, size: 4000);
                parameters.Add("@isSuccess", dbType: DbType.Boolean, direction: ParameterDirection.Output);

                var sqlQuery = "sp_Sync_InsertCreditCardTransaction";
                breakPoint = "connection database to execute stored procedure";

                using (var command = _dbTpf2003Context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameters);

                    _dbTpf2003Context.Database.OpenConnection();

                    using (var _query = command.ExecuteReader())
                    {
                        result = parameters.Get<bool>("@isSuccess");
                    }
                    if (!result)
                    {
                        _loggerWindows.LogCritical("AddCreditcardTransaction Error: {error}", parameters.Get<string>("@MessageDisplay"));
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);

            }
            return result;
        }

        private bool AddPaypalTransaction(PaypalTransaction item)
        {
            bool result = false;
            string breakPoint = "Start";

            try
            {
                breakPoint = "tbl OrderTransaction";
                DataTable tblOrderTransaction = new DataTable();
                tblOrderTransaction.Columns.AddRange(new DataColumn[32] {
                    new DataColumn("Token", typeof(string)), //1
                    new DataColumn("OcId",typeof(int)),//2
                    new DataColumn("TransactionId",typeof(string)),//3
                    new DataColumn("PayerId",typeof(string)),//4
                    new DataColumn("Amt",typeof(decimal)),//5
                    new DataColumn("Fee",typeof(decimal)),//6
                    new DataColumn("Created",typeof(DateTime)),//7
                    new DataColumn("Timestamp",typeof(string)),//fix 8
                    new DataColumn("Amountrecv",typeof(decimal)),//8
                    new DataColumn("ExchangeRate",typeof(decimal)),//9
                    new DataColumn("PaymentType",typeof(string)),//10
                    new DataColumn("PaymentStatus",typeof(string)),//11
                    new DataColumn("PendingReason",typeof(string)),//12
                    new DataColumn("ReasonCode",typeof(string)),//13
                    new DataColumn("VerifySign",typeof(string)),//14
                    new DataColumn("Status",typeof(string)),//15
                    new DataColumn("TxnProcessed",typeof(string)),//16
                    new DataColumn("Copy2Order",typeof(string)),//17
                    new DataColumn("Payer_Companyname",typeof(string)),//18
                    new DataColumn("Payer_Attention",typeof(string)),//19
                    new DataColumn("Payer_Fname",typeof(string)),//20
                    new DataColumn("Payer_Lname",typeof(string)),//21
                    new DataColumn("Payer_Address",typeof(string)),//22
                    new DataColumn("Payer_City",typeof(string)),//23
                    new DataColumn("Payer_State",typeof(string)),//24
                    new DataColumn("Payer_Country",typeof(string)),//25
                    new DataColumn("Payer_CountryCode",typeof(string)),//26
                    new DataColumn("Payer_Postcode",typeof(string)),//27
                    new DataColumn("Payer_Phone",typeof(string)),//28
                    new DataColumn("Payer_Email",typeof(string)),//29
                    new DataColumn("Payer_Addressstatus",typeof(string)),//30
                    new DataColumn("Payer_Status",typeof(string)),//31
                });

                if (item != null)
                {
                    tblOrderTransaction.Rows.Add(
                        item.Token, //1
                        long.Parse(item.OrderNumber),//2
                        item.TransactionId,//3
                        item.Client.PayerId,//4
                        item.Amount,//5
                        item.Fee,//6
                        item.Created,//7
                        "",
                        item.Amount,//8
                        item.ExchangeRate,//9
                        item.PaymentType,//10
                        item.PaymentStatus,//11
                        item.PendingReason,//12
                        item.ReasonCode,//13
                        "",//14
                        "current",//15
                        item.TransactionId != "" ? "yes" : "no", //16
                                                                 //Payer information
                        "yes", //17
                        item.Client.CompanyName, //18
                        item.Client.Attention, //19
                        item.Client.Firstname, //20
                        item.Client.Lastname, //21
                        item.Client.Address, //22
                        item.Client.City, //23
                        item.Client.State, //24
                        item.Client.Country, //25
                        item.Client.CountryCode, //26
                        item.Client.Postcode, //27
                        item.Client.Phone, //28
                        item.Client.Email, //29
                        item.Client.AddressStatus, //30
                        item.Client.Status //31
                    );

                }

                breakPoint = "Parameters";
                var parameters = new DynamicParameters();
                parameters.Add("@PaypalTransactions", tblOrderTransaction.AsTableValuedParameter("dbo.UDT_PayPalTransaction"));
                parameters.Add("@MessageDisplay", dbType: DbType.String, direction: ParameterDirection.Output, size: 4000);
                parameters.Add("@isSuccess", dbType: DbType.Boolean, direction: ParameterDirection.Output);

                var sqlQuery = "sp_Sync_InsertPayPalTransaction";
                breakPoint = "connection database to execute stored procedure";

                using (var command = _dbTpf2003Context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(parameters);

                    _dbTpf2003Context.Database.OpenConnection();
                    using (var _query = command.ExecuteReader())
                    {
                        result = parameters.Get<bool>("@isSuccess");
                    }

                    if (!result)
                    {
                        _loggerWindows.LogCritical("AddPaypalTransaction Error: {error}", parameters.Get<string>("@MessageDisplay"));
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Only Change order status for External Website
        /// </summary>
        /// <param name="poNumber"></param>
        /// <param name="newstatus"></param>
        /// <param name="DB"></param>
        /// <returns></returns>
        private bool ChangeOrderStatus(long ordernumber, OrderStatusSync newStatus)
        {
            bool result = false;
            string breakPoint = "Start";
            string strStatus = string.Empty;
            try
            {
                if (ordernumber > 0)
                {
                    switch (newStatus)
                    {
                        case OrderStatusSync.AwaitingPayment:
                            strStatus = OrderStatusSync.AwaitingPayment.GetDisplayName(); //"Awaiting Payment";
                            break;
                        case OrderStatusSync.Processed:
                            strStatus = OrderStatusSync.Processed.GetDisplayName(); //"processed";
                            break;
                        case OrderStatusSync.PartInvoiced:
                            strStatus = OrderStatusSync.PartInvoiced.GetDisplayName(); //"part-invoiced";
                            break;
                        case OrderStatusSync.FullInvoiced:
                            strStatus = OrderStatusSync.FullInvoiced.GetDisplayName(); //"full-invoiced";
                            break;
                        case OrderStatusSync.Cancelled:
                            strStatus = OrderStatusSync.Cancelled.GetDisplayName(); //"cancelled";
                            break;
                        case OrderStatusSync.Closed:
                            strStatus = OrderStatusSync.Closed.GetDisplayName(); //"closed";
                            break;
                    }

                    breakPoint = "Parameters";
                    var parameters = new DynamicParameters();
                    parameters.Add("@ocid", ordernumber);
                    parameters.Add("@status", strStatus);

                    parameters.Add("@MessageDisplay", dbType: DbType.String, direction: ParameterDirection.Output, size: 4000);
                    parameters.Add("@isSuccess", dbType: DbType.Boolean, direction: ParameterDirection.Output);

                    var sqlQuery = "sp_Sync_UpdateStatusOrderConfig";
                    breakPoint = "connection database to execute stored procedure";

                    using (var command = _dbTpfsystemContext.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(parameters);

                        _dbTpfsystemContext.Database.OpenConnection();
                        using (var _query = command.ExecuteReader())
                        {
                            result = parameters.Get<bool>("@isSuccess");
                        }

                        if (!result)
                        {
                            breakPoint = "Error at execute stored procedure";
                            _loggerWindows.LogCritical("ChangeOrderStatus Error: {error}", parameters.Get<string>("@MessageDisplay"));
                        }
                    }
                }
                else
                {
                    _loggerWindows.LogCritical("ChangeOrderStatus Warn: {warn}", GroupLog.OrderRepository);
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return result;
        }

        private bool AddOrderSyncTrackingExtent(IEnumerable<OrderSyncTrackingSignalR> orders)
        {
            bool result = false;
            string breakPoint = "Start";

            try
            {
                if (orders != null && orders.Count() > 0)
                {
                    List<SqlDataRecord> listOrders = new List<SqlDataRecord>();
                    SqlMetaData[] myRecordSchema =  {
                        new SqlMetaData("TpfOrderId", SqlDbType.BigInt),
                        new SqlMetaData("StoreId", SqlDbType.Int),
                        new SqlMetaData("PoNumber", SqlDbType.VarChar, 20),
                        new SqlMetaData("PendingDuration", SqlDbType.Int),
                        new SqlMetaData("OrderStatus", SqlDbType.VarChar, 20),
                        new SqlMetaData("RawData", SqlDbType.VarChar, 4000),
                        new SqlMetaData("SyncStatus", SqlDbType.Int)
                    };
                    foreach (var item in orders)
                    {
                        var record = new SqlDataRecord(myRecordSchema);
                        record.SetInt64(0, item.TPFOrderID);
                        record.SetInt32(1, item.StoreId);
                        record.SetString(2, item.PONumber.Trim());
                        record.SetInt32(3, item.PendingDuration);
                        record.SetString(4, item.OrderStatus);
                        record.SetString(5, item.RawData);
                        record.SetInt32(6, (int)item.SyncStatus);

                        listOrders.Add(record);
                    }

                    breakPoint = "Parameters";
                    var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "OrderTracking", SqlDbType = SqlDbType.Structured, Value = listOrders },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "MessageDisplay", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 4000 },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "isSuccess", DbType = DbType.Boolean, Direction = ParameterDirection.Output }
                    };

                    var sqlQuery = "sp_AddOrderTrackingExtent";
                    breakPoint = "connection database to execute stored procedure";

                    using (var command = _dbOnlineSyncDataContext.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = sqlQuery;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddRange(parameters);

                        _dbOnlineSyncDataContext.Database.OpenConnection();

                        using (var _query = command.ExecuteReader())
                        {
                            result = (bool)parameters[2].Value;
                        }
                        if (!result)
                        {
                            _loggerWindows.LogCritical("AddOrderSyncTrackingExtent Error: {error}", parameters[1].Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return result;
        }

        private bool AddInternalOrderNotes(long orderNumber, List<OrderNote> notes)
        {
            bool result = false;
            string breakPoint = "Start";

            try
            {
                List<SqlDataRecord> tblOrderNote = new List<SqlDataRecord>();
                SqlMetaData[] myRecordSchema =  {
                        new SqlMetaData("OcId", SqlDbType.BigInt),
                        new SqlMetaData("Note", SqlDbType.VarChar, 4000),
                        new SqlMetaData("EnteredBy", SqlDbType.Int)
                 };
                foreach (var item in notes)
                {
                    var record = new SqlDataRecord(myRecordSchema);
                    record.SetInt64(0, orderNumber);
                    record.SetString(1, item.Note);
                    record.SetInt32(2, StaffID.TPFSystem);

                    tblOrderNote.Add(record);
                }

                breakPoint = "Parameters";
                var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "OrderNotes", SqlDbType = SqlDbType.Structured, Value = tblOrderNote },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "MessageDisplay", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 500 },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "isSuccess", DbType = DbType.Boolean, Direction = ParameterDirection.Output }
                    };

                var sqlQuery = "sp_Sync_AddInternalOrderNotes";
                breakPoint = "connection database to execute stored procedure";

                using (var command = _dbTpfsystemContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);

                    _dbTpfsystemContext.Database.OpenConnection();

                    using (var _query = command.ExecuteReader())
                    {
                        result = (bool)parameters[2].Value;
                    }

                    if (!result)
                    {
                        _loggerWindows.LogCritical("AddInternalOrderNotes Error: {error}", parameters[1].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }
            return result;
        }

        private bool SyncStockByOrdernumber(long ocid)
        {
            string breakPoint = "Start";
            bool result = false;

            try
            {
                if (ocid <= 0)
                {
                    goto EndAction;
                }

                breakPoint = "build parameters";
                var parameters = new[]
                    {
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "ocid", Value = ocid },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "MessageDisplay", DbType = DbType.String, Direction = ParameterDirection.Output, Size = 4000 },
                        new Microsoft.Data.SqlClient.SqlParameter(){ ParameterName = "isSuccess", DbType = DbType.Boolean, Direction = ParameterDirection.Output }
                    };

                breakPoint = "connection database to Execute";
                string sqlQuery = "sp_ReSyncStockByOrdernumber";

                using (var command = _dbOnlineSyncDataContext.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sqlQuery;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);

                    _dbOnlineSyncDataContext.Database.OpenConnection();

                    using (var _query = command.ExecuteReader())
                    {
                        result = (bool)parameters[2].Value;
                    }
                    if (!result)
                    {
                        _loggerWindows.LogCritical("AddInternalOrderNotes Error: {error}", parameters[1].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerWindows.LogError(ex, "{Message}", ex.Message);
            }

        EndAction:

            return result;
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name.ToUpper() == column.ColumnName.ToUpper())
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
