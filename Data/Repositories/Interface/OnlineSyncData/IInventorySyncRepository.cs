namespace Data.Repositories.OnlineSyncData
{
	public interface IInventorySyncRepository : IRepository<Data.Databases.OnlineSyncData.InventorySync>
	{
		public Task<string> RequestStockToSync(string internalCodes, int storeId);
		public Task<string> RequestTurnOffSyncByItems(DataTable dtTurnOffSyncItems);
	}
}

