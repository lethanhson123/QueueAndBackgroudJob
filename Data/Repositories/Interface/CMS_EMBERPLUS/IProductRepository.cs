namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IProductRepository : IRepository<Data.Databases.CMS_EMBERPLUS.Product>
	{
		public Task<DataTable> GetMemberPlusProductNotSyncYetModelToDataTableAsync();
		public Task<string> UpdateStockSync(string product_json_data);
		public List<Data.Databases.CMS_EMBERPLUS.Product> GetBySKUsToList(List<long> SKUs);
	}
}

