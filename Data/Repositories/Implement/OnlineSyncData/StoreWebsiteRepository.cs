namespace Data.Repositories.OnlineSyncData
{
	public class StoreWebsiteRepository : Repository<Data.Databases.OnlineSyncData.StoreWebsite>, IStoreWebsiteRepository
	{
		private readonly OnlineSyncDataContext _context;
		public StoreWebsiteRepository(OnlineSyncDataContext context) : base(context)
		{
			_context = context;
		}
		public async Task<List<Data.Databases.OnlineSyncData.StoreWebsite>> GetByActiveAndStoreStatusToListAsync(bool active, string storeStatus)
		{
			List<Data.Databases.OnlineSyncData.StoreWebsite> result = new List<Data.Databases.OnlineSyncData.StoreWebsite> ();
			try
			{
				SqlParameter[] parameters =
				{
						new SqlParameter("@Active",active),
						new SqlParameter("@StoreStatus",storeStatus),
				};
				DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_StoreWebsiteSelectItemsByActiveAndStoreStatus", parameters);
				result = SQLHelper.ToList<Data.Databases.OnlineSyncData.StoreWebsite>(dataTable);
				return result;
			}
			catch (Exception ex)
			{
				string message = ex.Message;
			}
			return result;
		}
	}
}

