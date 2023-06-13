namespace BusinessServices.Models.MessageQueueModel
{
	public class MemberPlusOrderDeliveryNotDispatchQueueModel : CommonModel
	{
		public MemberPlusOrderDeliveryNotDispatchModel item { get; set; }
	}
	public class MemberPlusOrderDeliveryNotDispatchModel
	{
		public string ApiType { get; set; }
		public long WebOrderId { get; set; }
		public long DeliveryId { get; set; }
		public int CompanyID { get; set; }
		public string ThirdOrderId { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
