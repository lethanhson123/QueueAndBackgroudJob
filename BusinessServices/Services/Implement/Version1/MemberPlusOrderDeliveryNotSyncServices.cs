using System;
using System.Net;
using System.Threading.Tasks;
using BusinessServices.Models.MPlusSyncOrderAPI;
using BusinessServices.Services.Interface;
using Data.Databases.CMS_EMBERPLUS;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Utilities.Models.Settings.Base;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessServices.Services.Implement.Version1
{
	public partial class MemberPlusOrderDeliveryNotSyncServices : IMemberPlusOrderDeliveryNotSyncServices
	{
		private readonly ILogger<MemberPlusOrderDeliveryNotSyncServices> _loggerWindows;
		private readonly IMapper _mapper;
		private readonly Data.Repositories.BackgroundTask.IPushQueueRepository _pushQueueRepositoryBackgroundTask;
		private readonly Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryRepository _whOcDeliveryRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.IWebOrderRepository _webOrderRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationRepository _cmsConfigurationRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationTaskRepository _cmsConfigurationTaskRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryDetailRepository _whOcDeliveryDetailRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.IWebOrderDetailRepository _webOrderDetailRepositoryCMS_EMBERPLUS;
		private readonly Data.Repositories.CMS_EMBERPLUS.IProductRepository _productRepositoryCMS_EMBERPLUS;
		private ResponseLoginData TokenData { get; set; }
		public bool AutoStart { get; set; } = true;
		public string Name { get; set; } = "OrderSyncAPI";
		public string Key { get; set; }
		public string Url { get; set; }
		public string ID { get; set; }
		public int CompanyID { get; set; }
		public MemberPlusOrderDeliveryNotSyncServices(ILogger<MemberPlusOrderDeliveryNotSyncServices> loggerWindows
			, IMapper mapper
			, Data.Repositories.BackgroundTask.IPushQueueRepository pushQueueRepositoryBackgroundTask
			, Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryRepository whOcDeliveryRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.IWebOrderRepository webOrderRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationRepository cmsConfigurationRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.ICmsConfigurationTaskRepository cmsConfigurationTaskRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.IWhOcDeliveryDetailRepository whOcDeliveryDetailRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.IWebOrderDetailRepository webOrderDetailRepositoryCMS_EMBERPLUS
			, Data.Repositories.CMS_EMBERPLUS.IProductRepository productRepositoryCMS_EMBERPLUS
			)
		{
			_loggerWindows = loggerWindows;
			_mapper = mapper;
			_pushQueueRepositoryBackgroundTask = pushQueueRepositoryBackgroundTask;
			_whOcDeliveryRepositoryCMS_EMBERPLUS = whOcDeliveryRepositoryCMS_EMBERPLUS;
			_webOrderRepositoryCMS_EMBERPLUS = webOrderRepositoryCMS_EMBERPLUS;
			_cmsConfigurationRepositoryCMS_EMBERPLUS = cmsConfigurationRepositoryCMS_EMBERPLUS;
			_cmsConfigurationTaskRepositoryCMS_EMBERPLUS = cmsConfigurationTaskRepositoryCMS_EMBERPLUS;
			_whOcDeliveryDetailRepositoryCMS_EMBERPLUS = whOcDeliveryDetailRepositoryCMS_EMBERPLUS;
			_webOrderDetailRepositoryCMS_EMBERPLUS = webOrderDetailRepositoryCMS_EMBERPLUS;
			_productRepositoryCMS_EMBERPLUS = productRepositoryCMS_EMBERPLUS;
		}
		public async Task<List<MemberPlusOrderDeliveryNotSyncQueueModel>> PublishAsync()
		{
			List<MemberPlusOrderDeliveryNotSyncQueueModel> listQueueModel = new List<MemberPlusOrderDeliveryNotSyncQueueModel>();

			DataTable dtModel = await _whOcDeliveryRepositoryCMS_EMBERPLUS.GetMemberPlusOrderDeliveryModelToDataTableAsync();

			List<MemberPlusOrderDeliveryNotSyncModel> listModel = dtModel.ToList<MemberPlusOrderDeliveryNotSyncModel>();

			if (listModel.Count > 0)
			{
				listModel.ForEach(item =>
				{
					MemberPlusOrderDeliveryNotSyncModel model = new MemberPlusOrderDeliveryNotSyncModel();
					try
					{
						model.OrderId = item.OrderId;
						model.CompanyID = item.CompanyID;

						MemberPlusOrderDeliveryNotSyncQueueModel queueModel = new MemberPlusOrderDeliveryNotSyncQueueModel();
						queueModel.item = model;
						queueModel.create = DateTime.UtcNow;
						queueModel.action = ActionTypes.SYNC_ORDER_DELIVERY_NOTSYNC.ToString().ToUpper();
						queueModel.status = ActionStatus.NEW.ToString().ToUpper();

						//Data.Databases.BackgroundTask.PushQueue pushQueue = await _pushQueueRepositoryBackgroundTask.GetByIDAndActionAsync(queueModel.item.OrderId, queueModel.action);
						//if (pushQueue == null)
						//{
						//	pushQueue = new Data.Databases.BackgroundTask.PushQueue();
						//	pushQueue.Id = queueModel.item.OrderId;
						//	pushQueue.Action = queueModel.action;
						//	_pushQueueRepositoryBackgroundTask.Add(pushQueue);
						//	listQueueModel.Add(queueModel);
						//}

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

		public async Task<Dictionary<string, object>> SubcriberAsync(MemberPlusOrderDeliveryNotSyncQueueModel data)
		{
			Dictionary<string, object> rs = new Dictionary<string, object>();
			try
			{
				long orderId = data.item.OrderId;
				CompanyID = data.item.CompanyID;
				var orderIds = String.Join(",", data.item.OrderId);
				var isCreateDelivery = await _whOcDeliveryRepositoryCMS_EMBERPLUS.CreateDeliveryAsync(orderIds);
				if (isCreateDelivery == true)
				{
					var dataSubmit = await MappingDataSubmitAsync(orderId);
					dataSubmit?.ForEach(x =>
					{
						var resultSubmit = CreateOrders(x);
						if (resultSubmit.Data.Count > 0)
						{
							resultSubmit.Data?.ForEach(async t =>
							{
								var whOcDelivery = await _whOcDeliveryRepositoryCMS_EMBERPLUS.GetByIDAsync(t.ReferenceId);
								if (t.OrderNo != -1 && string.IsNullOrEmpty(t.ErrorMessage))
								{
									whOcDelivery.DeliveryStatus = "Processed";
									whOcDelivery.WhRefNo = t.OrderNo.ToString();
									whOcDelivery.Description = "Sync API Successfully";
								}
								else
								{
									whOcDelivery.DeliveryStatus = "Pending";
									whOcDelivery.WhRefNo = "-1";
									whOcDelivery.Description = t.ErrorMessage;
								}
								await _whOcDeliveryRepositoryCMS_EMBERPLUS.UpdateAsync(whOcDelivery);
								if (t.OrderNo != -1 && string.IsNullOrEmpty(t.ErrorMessage))
								{
									await UpdateStockAfterSyncProcAsync(whOcDelivery);
								}
							});
						}
						else
						{
						}
					});
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
		private int State()
		{
			try
			{
				Data.Databases.CMS_EMBERPLUS.CmsConfiguration cmsConfiguration = _cmsConfigurationRepositoryCMS_EMBERPLUS.GetCompanyIDAndStatus(CompanyID, 1);
				if (cmsConfiguration != null)
				{
					Data.Databases.CMS_EMBERPLUS.CmsConfigurationTask cmsConfigurationTask = _cmsConfigurationTaskRepositoryCMS_EMBERPLUS.GetCompanyIDAndConfigIDAndIsRun(CompanyID, cmsConfiguration.Id, true);
					if (cmsConfigurationTask != null)
					{
						Key = cmsConfigurationTask.TaskKey;
						Url = cmsConfigurationTask.TaskUrl;
					}
				}
				if (TokenData == null || DateTime.Now.ToUniversalTime() > TokenData.Expiration)
				{
					if (!string.IsNullOrEmpty(Key))
					{
						var sUser = this.Key.Split(';');
						if (sUser.Length > 1)
						{
							var model = new LoginModel(sUser[0], sUser[1]);
							var urlData = $"{Url}/login";
							var result = model.Login(urlData);

							if (result.Status)
							{
								TokenData = result.Data;
								return 2;
							}
							else
							{
								return 4;
							}
						}
					}
				}
				return 0;
			}
			catch (Exception ex)
			{
				return 4;
			}
		}

		private async Task<List<RequestDeliveryInfoModel>> MappingDataSubmitAsync(long orderId)
		{
			var resultData = new List<RequestDeliveryInfoModel>();
			try
			{
				var whOcDeliverys = await _whOcDeliveryRepositoryCMS_EMBERPLUS.GetByOrderIdToListAsync(orderId);

				if (whOcDeliverys.Count > 0)
				{
					var whOcDeliveryIDs = whOcDeliverys.Select(t => (long)t.WebOrderId).Distinct().ToList();				

					var webOrders = await _webOrderRepositoryCMS_EMBERPLUS.GetByIDsToListAsync(whOcDeliveryIDs);

					if (webOrders.Count>0)
					{
						whOcDeliverys = whOcDeliverys.Where(t => webOrders.Select(tx => tx.Id).Distinct().Contains(t.WebOrderId)).ToList();

						var clubCodes = whOcDeliverys.Select(x => x.ClubCode).Distinct().ToList();

						clubCodes.ForEach(t =>
						{
							var data = new RequestDeliveryInfoModel
							{
								ClubCode = null,
								ListDelivery = new List<Delivery>()
							};
							data.ClubCode = t;
							var temps = whOcDeliverys?.Where(x => x.ClubCode == t && x.IsSyncToWh == true).ToList();
							temps?.ForEach(o =>
							{
								var temp = new Delivery
								{
									ReferenceId = o.Id.ToString(),
									ShippingType = o.ShippingType ?? "",
									OrderId = o.WebOrderId.ToString(),
									MemberId = o.MemberId ?? "",
									Fname = o.Fname ?? "",
									DelLname = o.Lname ?? "",
									CompanyName = o.CompanyName ?? "",
									Street = $"{o.Addr1 ?? ""}|{o.Addr2 ?? ""}|{o.Addr3 ?? ""}",
									Suburb = o.Suburb ?? "",
									State = o.State ?? "",
									Postcode = o.Postcode ?? "",
									Country = o.Country ?? "",
									Email = o.Email ?? "",
									Phone = o.Phone ?? "",
									OrderType = o.OrderType ?? "",
									WhID = o.WhId.ToString(),
									DeliveryDetails = new List<DeliveryDetailModel>()
								};
								o.Details?.ForEach(d =>
								{
									var detail = new DeliveryDetailModel
									{

										RedeemId = webOrders.FirstOrDefault(tx => tx.Id == o.WebOrderId)?.Details.FirstOrDefault(tx => tx.Id == d.OcDetailId)?.RedeemId?.ToString() ?? "",
										OrderDetailId = d.OcDetailId.ToString(),
										ItemCode = d.ProCode ?? "",
										ItemName = d.ProName ?? "",
										ItemQty = d.DelQty,
										PrintName = d.PrintName ?? "",
										PrintImage = d.PrintImage ?? "",
										RawData = d.RawData ?? "",
									};
									temp.DeliveryDetails.Add(detail);
								});
								data.ListDelivery.Add(temp);
							});
							resultData.Add(data);
						});
					}
				}				
			}
			catch (Exception ex)
			{
				string message = ex.Message;
			}
			return resultData;
		}
		private ResponseModel CreateOrders(RequestDeliveryInfoModel models)
		{
			var result = new ResponseModel
			{
				Status = false
			};
			try
			{
				if (State() == 2)
				{
					var urlData = $"{Url}/public-api/orders/create";
					var token = $"Bearer {TokenData?.Token}";
					var typeContent = "application/json";
					var client = new RestClient(urlData);
					var request = new RestRequest
					{
						Method = Method.Post,
						Timeout = 60000
					};
					request.AddHeader("Content-Type", typeContent);
					request.AddHeader("Authorization", token);
					var body = JsonConvert.SerializeObject(models);
					request.AddParameter(typeContent, body, ParameterType.RequestBody);
					var response = client.Execute(request);
					if (response.StatusCode != HttpStatusCode.OK)
					{
						result.Status = false;
						result.Message = result.Message;
						result.Data = null;
						return result;
					}

					if (response.Content != null)
					{
						var resultResponse = JsonConvert.DeserializeObject<ResponseModel>(response.Content);
						if (resultResponse != null)
							result = resultResponse;
						else
						{
							result.Status = false;
							result.Message = $"Sync order to API FF Fail! ({response.Content})";
							return result;
						}
					}
					else
					{
						result.Status = false;
						result.Message = "Check Sync Connection Auth";
						return result;
					}
				}
			}
			catch (Exception ex)
			{
				result.Status = false;
				result.Message = ex.Message;
			}
			return result;
		}

		private async Task<bool> UpdateStockAfterSyncProcAsync(Data.Databases.CMS_EMBERPLUS.WhOcDelivery whOcDelivery)
		{
			var updated = false;
			try
			{
				var dataTable = await _whOcDeliveryRepositoryCMS_EMBERPLUS.UpdateStockAfterSyncToDataTableAsync(whOcDelivery.Id);
				if (dataTable == null)
				{
					return false;
				}
				updated = true;
				try
				{
					var webOrder = await _webOrderRepositoryCMS_EMBERPLUS.GetByIDAsync(whOcDelivery.WebOrderId);
					webOrder.SyncStatus = "Synchronized";
					await _webOrderRepositoryCMS_EMBERPLUS.UpdateAsync(webOrder);
				}
				catch (Exception e)
				{
					string mes = e.Message;
				}

				try
				{
					//var whOcDeliveryDetails = _whOcDeliveryDetailRepositoryCMS_EMBERPLUS.GetByOcDelIdToList(whOcDelivery.Id);
					//var whOcDeliveryDetailIDs = whOcDeliveryDetails.Select(t => t.OcDetailId).ToList();
					//var webOrderDetails=_webOrderDetailRepositoryCMS_EMBERPLUS.GetByWhOcDeliveryDetailIDsToList(whOcDeliveryDetailIDs);
					//var SKUs = webOrderDetails.Where(t => !new int?[] { 4, 10, 11 }.Contains(t.ProductType)).Select(t => long.Parse(t.Sku)).Distinct().ToList();
					//var products = _productRepositoryCMS_EMBERPLUS.GetBySKUsToList(SKUs);
					//foreach (var item in products)
					//{
					//	//UpdateCaching(item);
					//}
				}
				catch (Exception e)
				{
					string mes = e.Message;
				}
			}
			catch (Exception e)
			{
				string mes = e.Message;
			}
			return updated;
		}
	}
}
