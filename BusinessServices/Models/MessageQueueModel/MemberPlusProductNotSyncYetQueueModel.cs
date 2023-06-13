namespace BusinessServices.Models.MessageQueueModel
{
	public class MemberPlusProductNotSyncYetQueueModel : CommonModel
	{
		public MemberPlusProductNotSyncYetModel item { get; set; }
	}
	public class MemberPlusProductNotSyncYetModel
	{
		public string InternalCode { get; set; }
		public int ProdetailID { get; set; }
	}
}
