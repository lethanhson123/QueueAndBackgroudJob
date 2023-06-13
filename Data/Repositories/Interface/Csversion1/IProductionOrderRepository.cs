namespace Data.Repositories.Csversion1
{
	public interface IProductionOrderRepository : IRepository<Data.Databases.Csversion1.ProductionOrder>
	{
		public Task<DataTable> GetDispatchInfoByOrderIdsToDataTableAsync(string OrderIds);
	}
}

