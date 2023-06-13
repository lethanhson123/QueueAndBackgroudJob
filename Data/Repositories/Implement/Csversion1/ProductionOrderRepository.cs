namespace Data.Repositories.Csversion1
{
	public class ProductionOrderRepository : Repository<Data.Databases.Csversion1.ProductionOrder>, IProductionOrderRepository
	{
		private readonly Csversion1Context _context;
		public ProductionOrderRepository(Csversion1Context context) : base(context)
		{
			_context = context;
		}
		public async Task<DataTable> GetDispatchInfoByOrderIdsToDataTableAsync(string orderIds)
		{
			SqlParameter[] parameters =
				 {
					new SqlParameter("@OrderIds",orderIds),
				};
			string connection = _context.Database.GetConnectionString();
			DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "Sync_Sp_GetDispatchInfoByOrderIds", parameters);

			return dataTable;
		}
	}
}

