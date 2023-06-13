namespace BusinessServices.Models.MessageQueueModel
{
	public class MemberPlusOrderDeliveryNotSyncQueueModel : CommonModel
	{
		public MemberPlusOrderDeliveryNotSyncModel item { get; set; }
	}
	public class MemberPlusOrderDeliveryNotSyncModel
	{
		public long OrderId { get; set; }
		public int CompanyID { get; set; }
	}
}
