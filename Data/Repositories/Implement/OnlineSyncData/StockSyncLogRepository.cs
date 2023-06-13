namespace Data.Repositories.OnlineSyncData
{
public class StockSyncLogRepository : Repository<Data.Databases.OnlineSyncData.StockSyncLog>, IStockSyncLogRepository
{
private readonly OnlineSyncDataContext _context;
public StockSyncLogRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

