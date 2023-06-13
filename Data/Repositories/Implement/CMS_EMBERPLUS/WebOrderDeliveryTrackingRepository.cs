namespace Data.Repositories.CMS_EMBERPLUS
{
	public class WebOrderDeliveryTrackingRepository : Repository<Data.Databases.CMS_EMBERPLUS.WebOrderDeliveryTracking>, IWebOrderDeliveryTrackingRepository
	{
		private readonly CmsEmberplusContext _context;
		public WebOrderDeliveryTrackingRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public async Task<string> SyncOrderDeliveryNotDispatch(string apiType, string mberOrderId, string trackingNo, string courier, string trackingURL, DateTime processedDate, string tranId, string delStatus)
		{
			SqlParameter[] parameters =
				 {
					new SqlParameter("@ApiType",apiType),
					new SqlParameter("@MberOrderId",mberOrderId),
					new SqlParameter("@TrackingNo",trackingNo),
					new SqlParameter("@Courier",courier),
					new SqlParameter("@TrackingURL",trackingURL),
					new SqlParameter("@ProcessedDate",processedDate),
					new SqlParameter("@TranId",tranId),
					new SqlParameter("@DelStatus",delStatus),
				};
			string result = await SQLHelper.ExecuteNonQueryByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_SyncOrderDeliveryNotDispatch", parameters);
			return result;
		}
	}
}

