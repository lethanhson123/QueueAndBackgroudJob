namespace Data.Repositories.Csversion1
{
	public class ProductRepository : Repository<Data.Databases.Csversion1.Product>, IProductRepository
	{
		private readonly Csversion1Context _context;
		public ProductRepository(Csversion1Context context) : base(context)
		{
			_context = context;
		}
		public async Task<DataSet> GetSKUToDataSetAsync(long prodetailID)
		{			
			SqlParameter[] parameters =
			{
					new SqlParameter("@ProdetailID",prodetailID),
			};			
			DataSet dataSet = await SQLHelper.FillDataSetByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_SubscribeNotSyncProductByProdetailID", parameters);		
			return dataSet;
		}
	}
}

