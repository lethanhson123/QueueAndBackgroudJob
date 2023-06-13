namespace Data.Repositories.OnlineSyncData
{
public class OrderSyncTrackingRepository : Repository<Data.Databases.OnlineSyncData.OrderSyncTracking>, IOrderSyncTrackingRepository
{
private readonly OnlineSyncDataContext _context;
public OrderSyncTrackingRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

