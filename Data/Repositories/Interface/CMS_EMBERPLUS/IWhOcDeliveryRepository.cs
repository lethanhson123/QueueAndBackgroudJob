namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IWhOcDeliveryRepository : IRepository<Data.Databases.CMS_EMBERPLUS.WhOcDelivery>
	{
		public Task<DataTable> GetMemberPlusOrderDeliveryModelToDataTableAsync();
		public Task<bool> CreateDeliveryAsync(string order_ids);
		public Task<List<Data.Databases.CMS_EMBERPLUS.WhOcDelivery>> GetByOrderIdToListAsync(long orderId);
		public Task<Data.Databases.CMS_EMBERPLUS.WhOcDelivery> GetByIDAsync(long ID);
		public Task<DataTable> UpdateStockAfterSyncToDataTableAsync(long order_delivery_id);
		public Task<DataTable> GetOrderDeliveryNotDispatchToDataTableAsync();
	}
}

