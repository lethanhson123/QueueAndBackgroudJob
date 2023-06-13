namespace BusinessServices.Services.Implement.Version1
{
    public partial class MemberPlusProductNotSyncYetServices : IMemberPlusProductNotSyncYetServices
    {
        private readonly ILogger<MemberPlusProductNotSyncYetServices> _loggerWindows;
        private readonly IMapper _mapper;
        private readonly Data.Repositories.CMS_EMBERPLUS.IProductRepository _productRepositoryCMS_EMBERPLUS;
        private readonly Data.Repositories.Csversion1.IProductRepository _productRepositoryCsversion1;
        private readonly Data.Repositories.OnlineSyncData.IStoreWebsiteRepository _storeWebsiteRepository;
        private readonly Data.Repositories.OnlineSyncData.IInventorySyncRepository _inventorySyncRepository;
        public MemberPlusProductNotSyncYetServices(ILogger<MemberPlusProductNotSyncYetServices> loggerWindows
            , IMapper mapper
            , Data.Repositories.CMS_EMBERPLUS.IProductRepository productRepositoryCMS_EMBERPLUS
            , Data.Repositories.Csversion1.IProductRepository productRepositoryCsversion1
            , Data.Repositories.OnlineSyncData.IStoreWebsiteRepository storeWebsiteRepository
            , Data.Repositories.OnlineSyncData.IInventorySyncRepository inventorySyncRepository

            )
        {
            _loggerWindows = loggerWindows;
            _mapper = mapper;
            _productRepositoryCMS_EMBERPLUS = productRepositoryCMS_EMBERPLUS;
            _productRepositoryCsversion1 = productRepositoryCsversion1;
            _storeWebsiteRepository = storeWebsiteRepository;
            _inventorySyncRepository = inventorySyncRepository;
        }
        public async Task<List<MemberPlusProductNotSyncYetQueueModel>> PublishAsync()
        {
            List<MemberPlusProductNotSyncYetQueueModel> listMemberPlusProductNotSyncYetQueueModel = new List<MemberPlusProductNotSyncYetQueueModel>();

            DataTable dtMemberPlusProductNotSyncYetModel = await _productRepositoryCMS_EMBERPLUS.GetMemberPlusProductNotSyncYetModelToDataTableAsync();

            List<MemberPlusProductNotSyncYetModel> listMemberPlusProductNotSyncYetModel = dtMemberPlusProductNotSyncYetModel.ToList<MemberPlusProductNotSyncYetModel>();

            List<Data.Databases.BackgroundTask.PushQueue> listPushQueueNew = new List<Data.Databases.BackgroundTask.PushQueue>();

            if (listMemberPlusProductNotSyncYetModel.Count > 0)
            {
                listMemberPlusProductNotSyncYetModel.ForEach(item =>
                {
                    MemberPlusProductNotSyncYetModel memberPlusProductNotSyncYetModel = new MemberPlusProductNotSyncYetModel();
                    try
                    {
                        memberPlusProductNotSyncYetModel.InternalCode = item.InternalCode;
                        memberPlusProductNotSyncYetModel.ProdetailID = int.Parse(Regex.Replace(memberPlusProductNotSyncYetModel.InternalCode, @"[^\d]", ""));

                        MemberPlusProductNotSyncYetQueueModel memberPlusProductNotSyncYetQueueModel = new MemberPlusProductNotSyncYetQueueModel();
                        memberPlusProductNotSyncYetQueueModel.item = memberPlusProductNotSyncYetModel;
                        memberPlusProductNotSyncYetQueueModel.create = DateTime.UtcNow;
                        memberPlusProductNotSyncYetQueueModel.action = ActionTypes.SYNC_PRODUCT.ToString().ToUpper();
                        memberPlusProductNotSyncYetQueueModel.status = ActionStatus.NEW.ToString().ToUpper();

                        listMemberPlusProductNotSyncYetQueueModel.Add(memberPlusProductNotSyncYetQueueModel);
                    }
                    catch (Exception exception)
                    {
                        string message = exception.Message;
                    }
                });
            }
            return listMemberPlusProductNotSyncYetQueueModel;
        }
        public async Task<Dictionary<string, object>> SubcriberAsync(MemberPlusProductNotSyncYetQueueModel data)
        {
            Dictionary<string, object> rs = new Dictionary<string, object>();
            try
            {
                List<string> listResultRequestStockToSync = new List<string>();
                string resultUpdateStockSync = "-1";
                string resultRequestTurnOffSyncByItems = "-1";
                //RequestSyncStock
                List<Data.Databases.OnlineSyncData.StoreWebsite> listStoreWebsite = await _storeWebsiteRepository.GetByActiveAndStoreStatusToListAsync(true, "active");
                foreach (Data.Databases.OnlineSyncData.StoreWebsite storeWebsite in listStoreWebsite)
                {
                    string resultRequestStockToSync = await _inventorySyncRepository.RequestStockToSync(data.item.InternalCode, storeWebsite.Id);
                    listResultRequestStockToSync.Add(resultRequestStockToSync);
                }

                //data.item.ProdetailID = 5165;
                DataSet dsSKU = await _productRepositoryCsversion1.GetSKUToDataSetAsync(data.item.ProdetailID);

                List<SKU> listSKU = dsSKU.Tables[0].ToList<SKU>();

                SKU sKU = new SKU();
                if (listSKU.Count > 0)
                {
                    sKU = listSKU[0];
                    DataTable tblAvailable = dsSKU.Tables[1];
                    if (tblAvailable != null)
                    {
                        if (tblAvailable.Rows.Count > 0)
                        {
                            foreach (DataRow row in tblAvailable.Rows)
                            {
                                try
                                {
                                    int whId = int.Parse(row["WhId"].ToString().Trim());
                                    int available = int.Parse(row["Available"].ToString().Trim());
                                    sKU.Available.Add(whId, available);
                                }
                                catch (Exception exception)
                                {
                                    string message = exception.Message;
                                }
                            }
                        }
                        else
                        {
                            sKU.Available.Add(sKU.PrimaryWarehouse, 0);
                        }
                    }
                }

                if (sKU != null)
                {
                    if (sKU.Id > 0)
                    {
                        string product_json_data = JsonConvert.SerializeObject(sKU);
                        resultUpdateStockSync = await _productRepositoryCMS_EMBERPLUS.UpdateStockSync(product_json_data);

                        //turnOffStockSync
                        DataTable dtTurnOffSyncItems = new DataTable();
                        dtTurnOffSyncItems.Columns.Add("InternalCode", typeof(string));
                        dtTurnOffSyncItems.Columns.Add("ExternalCode", typeof(string));
                        dtTurnOffSyncItems.Columns.Add("StoreID", typeof(int));
                        dtTurnOffSyncItems.Columns.Add("SyncStatus", typeof(int));
                        dtTurnOffSyncItems.Columns.Add("LastSyncDate", typeof(DateTime));

                        foreach (Data.Databases.OnlineSyncData.StoreWebsite storeWebsite in listStoreWebsite)
                        {
                            DataRow drTurnOffSyncItems = dtTurnOffSyncItems.NewRow();
                            drTurnOffSyncItems["InternalCode"] = data.item.InternalCode;
                            drTurnOffSyncItems["ExternalCode"] = "";
                            drTurnOffSyncItems["StoreID"] = storeWebsite.Id;
                            drTurnOffSyncItems["SyncStatus"] = (int)SyncStatus.Synced;
                            drTurnOffSyncItems["LastSyncDate"] = DateTime.UtcNow;
                            dtTurnOffSyncItems.Rows.Add(drTurnOffSyncItems);
                        }
                        resultRequestTurnOffSyncByItems = await _inventorySyncRepository.RequestTurnOffSyncByItems(dtTurnOffSyncItems);
                    }
                }
                rs["c"] = ConstantCode.SUCCESSFULL;
                rs["m"] = ConstantMessage.SUCCESSFULL;
            }
            catch (Exception exception)
            {
                rs["c"] = ConstantCode.DB_EXCUTE_FAIL;
                rs["m"] = ConstantMessage.UPDATE_DATA_TO_DB_FAIL;
                rs["d"] = exception.Message;
            }

            return rs;
        }
    }
}
