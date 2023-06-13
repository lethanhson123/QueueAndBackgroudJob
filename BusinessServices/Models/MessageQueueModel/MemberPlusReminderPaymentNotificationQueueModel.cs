namespace BusinessServices.Models.MessageQueueModel
{
	public class MemberPlusReminderPaymentNotificationQueueModel : CommonModel
	{
		public MemberPlusReminderPaymentNotificationModel item { get; set; }
	}
	public class MemberPlusReminderPaymentNotificationModel
	{
		public int CompanyID { get; set; }
		public int MinuteSend { get; set; }
		public long OrderId { get; set; }
		public string TypeNotification { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }		
		public decimal Total { get; set; }
		public string PaymentType { get; set; }
	}
}
