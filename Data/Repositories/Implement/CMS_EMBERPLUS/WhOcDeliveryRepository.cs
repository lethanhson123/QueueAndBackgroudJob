using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Data.Repositories.CMS_EMBERPLUS
{
	public class WhOcDeliveryRepository : Repository<Data.Databases.CMS_EMBERPLUS.WhOcDelivery>, IWhOcDeliveryRepository
	{
		private readonly CmsEmberplusContext _context;
		public WhOcDeliveryRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public async Task<DataTable> GetMemberPlusOrderDeliveryModelToDataTableAsync()
		{			
			DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_MemberPlusOrderDeliveryModel");
			return dataTable;
		}
		public async Task<bool> CreateDeliveryAsync(string order_ids)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(_context.Database.GetConnectionString()))
				{
					using (SqlCommand cmd = new SqlCommand("SYNC_Create_DeliveryRequest", conn))
					{
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@order_ids", SqlDbType.NVarChar).Value = order_ids;
						cmd.Parameters.AddWithValue("@result", SqlDbType.NVarChar).Direction = ParameterDirection.Output;
						cmd.Parameters["@result"].Value = "fail";
						conn.Open();
						await cmd.ExecuteNonQueryAsync();
						string result = Convert.ToString(cmd.Parameters["@result"].Value);
						conn.Close();
						if (string.IsNullOrEmpty(result) != true)
						{
							return false;
						}
						return true;
					}
				}
			}
			catch (Exception e)
			{
				string mes = e.Message;
			}

			return false;
		}
		public async Task<bool> UpdateStockAfterSyncProcAsync(string order_delivery_id)
		{
			SqlParameter[] parameters =
				 {
					new SqlParameter("@order_delivery_id",order_delivery_id),
				};
			await SQLHelper.ExecuteNonQueryByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_OrderDelivery_UpdateStockAfterSync", parameters);
			return true;
		}
		public async Task<List<Data.Databases.CMS_EMBERPLUS.WhOcDelivery>> GetByOrderIdToListAsync(long orderId)
		{
			var result = await _context.Set<Data.Databases.CMS_EMBERPLUS.WhOcDelivery>().AsNoTracking().Where(item => item.WebOrderId == orderId && item.Status == 1 && item.IsSyncToWh == true && (item.WhRefNo == string.Empty || item.WhRefNo == "-1")).ToListAsync();
			return result;
		}
		public async Task<Data.Databases.CMS_EMBERPLUS.WhOcDelivery> GetByIDAsync(long ID)
		{
			var result = await _context.Set<Data.Databases.CMS_EMBERPLUS.WhOcDelivery>().AsNoTracking().FirstOrDefaultAsync(item => item.Id == ID);
			return result;
		}
		public async Task<DataTable> UpdateStockAfterSyncToDataTableAsync(long order_delivery_id)
		{
			SqlParameter[] parameters =
				 {
					new SqlParameter("@order_delivery_id",order_delivery_id),
				};
			DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_OrderDelivery_UpdateStockAfterSync", parameters);

			return dataTable;
		}
		public async Task<DataTable> GetOrderDeliveryNotDispatchToDataTableAsync()
		{
			DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "Sync_Sp_GetDeliveryNotDispatchYet");

			return dataTable;
		}
	}
}

