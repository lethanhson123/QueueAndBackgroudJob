namespace BusinessServices.Services.Implement.Version1
{
    public partial class MemberPlusReminderPaymentNotificationServices : IMemberPlusReminderPaymentNotificationServices
    {
        private readonly ILogger<MemberPlusReminderPaymentNotificationServices> _loggerWindows;
        private readonly Data.Repositories.CMS_EMBERPLUS.IWebOrderRepository _webOrderRepositoryCMS_EMBERPLUS;
        private readonly Data.Repositories.CMS_EMBERPLUS.IOrderNotificationRepository _orderNotificationRepositoryCMS_EMBERPLUS;
        private readonly Data.Repositories.CMS_EMBERPLUS.ICmsTriggerEmailRepository _cmsTriggerEmailRepositoryCMS_EMBERPLUS;
        private readonly ISendMailServices _sendMailServices;
        public MemberPlusReminderPaymentNotificationServices(ILogger<MemberPlusReminderPaymentNotificationServices> loggerWindows
            , Data.Repositories.CMS_EMBERPLUS.IWebOrderRepository webOrderRepositoryCMS_EMBERPLUS
            , Data.Repositories.CMS_EMBERPLUS.IOrderNotificationRepository orderNotificationRepositoryCMS_EMBERPLUS
            , Data.Repositories.CMS_EMBERPLUS.ICmsTriggerEmailRepository cmsTriggerEmailRepositoryCMS_EMBERPLUS
            , ISendMailServices sendMailServices
            )
        {
            _loggerWindows = loggerWindows;
            _webOrderRepositoryCMS_EMBERPLUS = webOrderRepositoryCMS_EMBERPLUS;
            _orderNotificationRepositoryCMS_EMBERPLUS = orderNotificationRepositoryCMS_EMBERPLUS;
            _cmsTriggerEmailRepositoryCMS_EMBERPLUS = cmsTriggerEmailRepositoryCMS_EMBERPLUS;
            _sendMailServices = sendMailServices;
        }
        public async Task<List<MemberPlusReminderPaymentNotificationQueueModel>> PublishAsync()
        {
            List<MemberPlusReminderPaymentNotificationQueueModel> listMemberPlusReminderPaymentNotificationQueueModel = new List<MemberPlusReminderPaymentNotificationQueueModel>();

            string typeNotification = ConstantMessage.ReminderPayment;
            DataTable dtMemberPlusReminderPaymentNotificationModel = await _webOrderRepositoryCMS_EMBERPLUS.GetOrderNotificationByTypeNotificationToDataTableAsync(typeNotification);

            List<MemberPlusReminderPaymentNotificationModel> listMemberPlusReminderPaymentNotificationModel = dtMemberPlusReminderPaymentNotificationModel.ToList<MemberPlusReminderPaymentNotificationModel>();

            List<Data.Databases.BackgroundTask.PushQueue> listPushQueueNew = new List<Data.Databases.BackgroundTask.PushQueue>();

            if (listMemberPlusReminderPaymentNotificationModel.Count > 0)
            {
                listMemberPlusReminderPaymentNotificationModel.ForEach(item =>
                {
                    try
                    {
                        MemberPlusReminderPaymentNotificationQueueModel memberPlusReminderPaymentNotificationQueueModel = new MemberPlusReminderPaymentNotificationQueueModel();
                        memberPlusReminderPaymentNotificationQueueModel.item = item;
                        memberPlusReminderPaymentNotificationQueueModel.create = DateTime.UtcNow;
                        memberPlusReminderPaymentNotificationQueueModel.action = ActionTypes.ReminderPaymentNotification.ToString().ToUpper();
                        memberPlusReminderPaymentNotificationQueueModel.status = ActionStatus.NEW.ToString().ToUpper();

                        bool isPayment = IsPayment(item.OrderId, item.PaymentType);
                        if (isPayment == false)
                        {
                            listMemberPlusReminderPaymentNotificationQueueModel.Add(memberPlusReminderPaymentNotificationQueueModel);
                        }
                    }
                    catch (Exception exception)
                    {
                        string message = exception.Message;
                    }
                });
            }
            return listMemberPlusReminderPaymentNotificationQueueModel;
        }      
        public async Task<Dictionary<string, object>> SubcriberAsync(MemberPlusReminderPaymentNotificationQueueModel data)
        {
            Dictionary<string, object> rs = new Dictionary<string, object>();
            try
            {
                Data.Databases.CMS_EMBERPLUS.CmsTriggerEmail cmsTriggerEmail = await _cmsTriggerEmailRepositoryCMS_EMBERPLUS.GetByCompanyIDAndKeyAndStatus(data.item.CompanyID, ConstantMessage.REMINDER_PAYMENT_NOTIFICATION, 1);
                if (cmsTriggerEmail != null)
                {
                    var query = new System.Collections.Specialized.NameValueCollection
                              {
                                  {"FirstName",data.item.FirstName},
                                  {"LastName",data.item.LastName},
                                  {"OrderId", data.item.OrderId.ToString()},
                                  {"Total", data.item.Total.ToString()}
                              };
                    cmsTriggerEmail.Title = StringHelper.SetTitleOfReminderPaymentNotification(cmsTriggerEmail.Title, query);
                    cmsTriggerEmail.Template = StringHelper.SetTemplateOfReminderPaymentNotification(cmsTriggerEmail.Template, query);

                    string mailFrom = AppSettingsConstant.Application.Emails["DefaultFrom"];

                    string[] mailToList = new string[] { "sohu.le@tpfgroup.cc", "josh.vu@tpfgroup.cc" };
                    //string[] mailToList = new string[] { data.item.Email };

                    bool isSendMail = await _sendMailServices.SendMailAsync(mailFrom, mailToList, cmsTriggerEmail.Title, cmsTriggerEmail.Template);
                    if (isSendMail == true)
                    {
                        Data.Databases.CMS_EMBERPLUS.OrderNotification orderNotification = new Data.Databases.CMS_EMBERPLUS.OrderNotification();
                        orderNotification.ID = Guid.NewGuid().ToString("N");
                        orderNotification.OrderID = data.item.OrderId;
                        orderNotification.DateSend = DateTime.Now;
                        orderNotification.TypeNotification = ConstantMessage.ReminderPayment;
                        orderNotification.Description = "Reminder Payment to user " + data.item.FirstName + " " + data.item.LastName;
                        orderNotification.CompanyID = data.item.CompanyID;
                        await _orderNotificationRepositoryCMS_EMBERPLUS.AddAsync(orderNotification);
                    }
                }
                else
                {
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
		private bool IsPayment(long orderId, string paymentType)
		{
			bool result = false;

			//(CMSWeb) more logic here but always return false

			//BusinessServices.Dbs.CMS_EMBERPLUS_DEV.PaymentTransation paymentTransation = _paymentTransationRepositoryCMS_EMBERPLUS.GetByOrderIDAndStatus(orderId, 1);
			//if (paymentTransation != null)
			//{				
			//}

			return result;
		}
	}
}
