namespace Data.Repositories.OnlineSyncData
{
	public interface IStoreWebsiteRepository : IRepository<Data.Databases.OnlineSyncData.StoreWebsite>
	{
		public Task<List<Data.Databases.OnlineSyncData.StoreWebsite>> GetByActiveAndStoreStatusToListAsync(bool active, string storeStatus);
	}
}

