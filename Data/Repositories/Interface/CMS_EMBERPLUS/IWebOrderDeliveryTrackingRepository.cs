namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IWebOrderDeliveryTrackingRepository : IRepository<Data.Databases.CMS_EMBERPLUS.WebOrderDeliveryTracking>
	{
		public Task<string> SyncOrderDeliveryNotDispatch(string apiType, string mberOrderId, string trackingNo, string courier, string trackingURL, DateTime processedDate, string tranId, string delStatus);
	}
}

