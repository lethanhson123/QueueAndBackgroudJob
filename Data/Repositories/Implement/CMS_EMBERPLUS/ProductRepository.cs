using Data.Databases.CMS_EMBERPLUS;
using Utilities.Helpers;

namespace Data.Repositories.CMS_EMBERPLUS
{
	public class ProductRepository : Repository<Data.Databases.CMS_EMBERPLUS.Product>, IProductRepository
	{
		private readonly CmsEmberplusContext _context;
		public ProductRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public async Task<DataTable> GetMemberPlusProductNotSyncYetModelToDataTableAsync()
		{
			DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_MemberPlusProductNotSyncYet");

			return dataTable;
		}
		public async Task<string> UpdateStockSync(string product_json_data)
		{
			string result = "";
			try
			{
				SqlParameter[] parameters =
				{
						new SqlParameter("@product_json_data",product_json_data),
				};
				result = await SQLHelper.ExecuteNonQueryByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_Product_UpdateStockSync", parameters);
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}
		public List<Data.Databases.CMS_EMBERPLUS.Product> GetBySKUsToList(List<long> SKUs)
		{
			var result = _context.Set<Data.Databases.CMS_EMBERPLUS.Product>().AsNoTracking().Where(item => SKUs.Contains(item.Skuid.Value)).ToList();
			return result;
		}
	}
}

