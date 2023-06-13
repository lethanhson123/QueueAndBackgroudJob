namespace Data.Repositories.OnlineSyncData
{
public class SyncLogRepository : Repository<Data.Databases.OnlineSyncData.SyncLog>, ISyncLogRepository
{
private readonly OnlineSyncDataContext _context;
public SyncLogRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

