using System.Data;
using Utilities.MPlusSyncOrderUtility;

namespace Data.Repositories.CMS_EMBERPLUS
{
	public class WebOrderRepository : Repository<Data.Databases.CMS_EMBERPLUS.WebOrder>, IWebOrderRepository
	{
		private readonly CmsEmberplusContext _context;
		public WebOrderRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public async Task<DataTable> GetOrderNotificationByTypeNotificationToDataTableAsync(string typeNotification)
		{
			SqlParameter[] parameters =
				 {
					new SqlParameter("@type_Notification",typeNotification),
				};
			DataTable dataTable = await SQLHelper.FillDataTableByStoredProcedureAsync(_context.Database.GetConnectionString(), "sp_OrderNotificationByTypeNotification", parameters);
			return dataTable;
		}
		public async Task<Data.Databases.CMS_EMBERPLUS.WebOrder> GetByIDAsync(long ID)
		{
			var result = await _context.Set<Data.Databases.CMS_EMBERPLUS.WebOrder>().AsNoTracking().FirstOrDefaultAsync(item => item.Id == ID);
			return result;
		}		
		public async Task<List<Data.Databases.CMS_EMBERPLUS.WebOrder>> GetByIDsToListAsync(List<long> IDs)
		{
			var result = await _context.Set<Data.Databases.CMS_EMBERPLUS.WebOrder>().AsNoTracking().Where(item => IDs.Contains(item.Id) && item.OrderStatus == "Processing").ToListAsync();
			return result;
		}
	}
}

