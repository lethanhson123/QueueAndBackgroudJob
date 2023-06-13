namespace BusinessServices.Models.MessageQueueModel
{
	public class TPFOrderDeliveryNotDispatchQueueModel : CommonModel
	{
		public TPFOrderDeliveryNotDispatchModel item { get; set; }
	}
	public class TPFOrderDeliveryNotDispatchModel
	{		
		public string ApiType { get; set; }
		public string ClubName { get; set; }
		public string MberOrderId { get; set; }
		public string DelStatus { get; set; }
		public string TranId { get; set; }
		public DateTime ProcessedDate { get; set; }
		public string TrackingNo { get; set; }
		public string TrackingURL { get; set; }
		public string Courier { get; set; }

	}
}
