namespace Data.Repositories.Csversion1
{
	public interface IProductRepository : IRepository<Data.Databases.Csversion1.Product>
	{
		public Task<DataSet> GetSKUToDataSetAsync(long prodetailID);
	}
}

