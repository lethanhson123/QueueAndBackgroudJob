namespace Data.Repositories.OnlineSyncData
{
	public class InventorySyncRepository : Repository<Data.Databases.OnlineSyncData.InventorySync>, IInventorySyncRepository
	{
		private readonly OnlineSyncDataContext _context;
		public InventorySyncRepository(OnlineSyncDataContext context) : base(context)
		{
			_context = context;
		}
		public async Task<string> RequestStockToSync(string internalCodes, int storeId)
		{
			string result = "";
			try
			{
				SqlParameter[] parameters =
				{
						new SqlParameter("@InternalCodes",internalCodes),
						new SqlParameter("@StoreId",storeId),
						new SqlParameter("@isSuccess",""),
						new SqlParameter("@MessageDisplay",""),
				};
				parameters[2].Direction = ParameterDirection.Output;
				parameters[3].Direction = ParameterDirection.Output;
				result = await SQLHelper.ExecuteNonQueryByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_requestStockToSync", parameters);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
		public async Task<string> RequestTurnOffSyncByItems(DataTable dtTurnOffSyncItems)
		{
			string result = "";
			try
			{
				SqlParameter[] parameters =
				{
						new SqlParameter("@TurnOffSyncItems",dtTurnOffSyncItems),						
						new SqlParameter("@isSuccess",""),
						new SqlParameter("@MessageDisplay",""),
				};
				parameters[1].Direction = ParameterDirection.Output;
				parameters[2].Direction = ParameterDirection.Output;
				result = await SQLHelper.ExecuteNonQueryByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_requestTurnOffSyncByItems", parameters);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
	}
}

