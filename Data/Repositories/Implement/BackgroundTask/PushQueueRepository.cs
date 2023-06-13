using Data.Databases.BackgroundTask;

namespace Data.Repositories.BackgroundTask
{
	public class PushQueueRepository : Repository<Data.Databases.BackgroundTask.PushQueue>, IPushQueueRepository
	{
		private readonly BackgroundTaskContext _context;
		public PushQueueRepository(BackgroundTaskContext context) : base(context)
		{
			_context = context;
		}
		public async Task<List<string>> GetQueueToListAsync(string actionTypeToUpper)
		{
			var result = await _context.Set<Data.Databases.BackgroundTask.PushQueue>().Where(item => item.Action.Equals(actionTypeToUpper)).Select(item => item.Queue).ToListAsync();
			return result;
		}
		public async Task<PushQueue> GetByIDAndActionAsync(int ID, string action)
		{
			var result = await _context.Set<Data.Databases.BackgroundTask.PushQueue>().AsNoTracking().FirstOrDefaultAsync(item => item.Id == ID && item.Action == action);
			return result;
		}		
	}
}

