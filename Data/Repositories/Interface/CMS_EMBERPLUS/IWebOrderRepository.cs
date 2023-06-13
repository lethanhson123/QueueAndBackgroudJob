namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IWebOrderRepository : IRepository<Data.Databases.CMS_EMBERPLUS.WebOrder>
	{
		public Task<DataTable> GetOrderNotificationByTypeNotificationToDataTableAsync(string typeNotification);
		public Task<Data.Databases.CMS_EMBERPLUS.WebOrder> GetByIDAsync(long ID);		
		public Task<List<Data.Databases.CMS_EMBERPLUS.WebOrder>> GetByIDsToListAsync(List<long> IDs);
	}
}

