namespace Data.Repositories.OnlineSyncData
{
public class OrderSyncLogRepository : Repository<Data.Databases.OnlineSyncData.OrderSyncLog>, IOrderSyncLogRepository
{
private readonly OnlineSyncDataContext _context;
public OrderSyncLogRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

