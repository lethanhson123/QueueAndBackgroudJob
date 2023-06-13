namespace Data.Repositories.OnlineSyncData
{
public class VStockSyncLogRepository : Repository<Data.Databases.OnlineSyncData.VStockSyncLog>, IVStockSyncLogRepository
{
private readonly OnlineSyncDataContext _context;
public VStockSyncLogRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

