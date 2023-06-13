

namespace BusinessServices.Services.Implement.Version1
{
	public partial class MemberPlusOrderDeliveryNotDispatchServices : IMemberPlusOrderDeliveryNotDispatchServices
	{
		private readonly ILogger<MemberPlusOrderDeliveryNotDispatchServices> _loggerWindows;
		private readonly IMapper _mapper;
		private readonly Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryRepository _whOcDeliveryRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.IWebOrderDeliveryTrackingRepository _webOrderDeliveryTrackingRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.Csversion1.IProductionOrderRepository _productionOrderRepositoryCsversion1;
		public MemberPlusOrderDeliveryNotDispatchServices(ILogger<MemberPlusOrderDeliveryNotDispatchServices> loggerWindows
			, IMapper mapper
			, Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryRepository whOcDeliveryRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.IWebOrderDeliveryTrackingRepository webOrderDeliveryTrackingRepositoryCMS_EMBERPLUS
			, Data.Repositories.Csversion1.IProductionOrderRepository productionOrderRepositoryCsversion1
			)
		{
			_loggerWindows = loggerWindows;
			_mapper = mapper;
			_whOcDeliveryRepositoryCMS_EMBERPLUS = whOcDeliveryRepositoryCMS_EMBERPLUS;
			_webOrderDeliveryTrackingRepositoryCMS_EMBERPLUS = webOrderDeliveryTrackingRepositoryCMS_EMBERPLUS;
			_productionOrderRepositoryCsversion1 = productionOrderRepositoryCsversion1;
		}
		public async Task<List<MemberPlusOrderDeliveryNotDispatchQueueModel>> PublishAsync()
		{
			List<MemberPlusOrderDeliveryNotDispatchQueueModel> listQueueModel = new List<MemberPlusOrderDeliveryNotDispatchQueueModel>();
			DataTable dtModel = await _whOcDeliveryRepositoryCMS_EMBERPLUS.GetOrderDeliveryNotDispatchToDataTableAsync();

			List<MemberPlusOrderDeliveryNotDispatchModel> listModel = dtModel.ToList<MemberPlusOrderDeliveryNotDispatchModel>();

			if (listModel.Count > 0)
			{
				listModel.ForEach(item =>
				{
					MemberPlusOrderDeliveryNotDispatchModel model = new MemberPlusOrderDeliveryNotDispatchModel();
					try
					{
						model.ApiType = item.ApiType;
						model.WebOrderId = item.WebOrderId;
						model.DeliveryId = item.DeliveryId;
						model.CompanyID = item.CompanyID;
						model.ThirdOrderId = item.ThirdOrderId;
						model.CreateDate = item.CreateDate;

						MemberPlusOrderDeliveryNotDispatchQueueModel queueModel = new MemberPlusOrderDeliveryNotDispatchQueueModel();
						queueModel.item = model;
						queueModel.create = DateTime.UtcNow;
						queueModel.action = ActionTypes.SYNC_ORDER_DELIVERY_NOT_DISPATCH.ToString().ToUpper();
						queueModel.status = ActionStatus.NEW.ToString().ToUpper();

						listQueueModel.Add(queueModel);
					}
					catch (Exception exception)
					{
						string message = exception.Message;
					}
				});
			}
			return listQueueModel;
		}
		public async Task<Dictionary<string, object>> SubcriberAsync(MemberPlusOrderDeliveryNotDispatchQueueModel data)
		{
			Dictionary<string, object> rs = new Dictionary<string, object>();
			try
			{
				var orderIds = String.Join(",", data.item.ThirdOrderId);
				DataTable dtModel = await _productionOrderRepositoryCsversion1.GetDispatchInfoByOrderIdsToDataTableAsync(orderIds);
				if (dtModel != null)
				{
					if (dtModel.Rows.Count > 1)
					{
						List<TPFOrderDeliveryNotDispatchModel> listModel = dtModel.ToList<TPFOrderDeliveryNotDispatchModel>();
						if (listModel != null)
						{
							if (listModel.Count > 0)
							{
								foreach (TPFOrderDeliveryNotDispatchModel model in listModel)
								{
									await _webOrderDeliveryTrackingRepositoryCMS_EMBERPLUS.SyncOrderDeliveryNotDispatch(model.ApiType, model.MberOrderId, model.TrackingNo, model.Courier, model.TrackingURL, model.ProcessedDate, model.TranId, model.DelStatus);
								}
							}
						}
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
