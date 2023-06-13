using Data.Databases.BackgroundTask;

namespace Data.Repositories.BackgroundTask
{
	public interface IPushQueueRepository : IRepository<Data.Databases.BackgroundTask.PushQueue>
	{
		public Task<List<string>> GetQueueToListAsync(string actionTypeToUpper);
		public Task<PushQueue> GetByIDAndActionAsync(int ID, string action);		
	}
}

