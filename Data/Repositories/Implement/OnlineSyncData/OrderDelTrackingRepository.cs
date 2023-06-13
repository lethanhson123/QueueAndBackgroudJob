namespace Data.Repositories.OnlineSyncData
{
public class OrderDelTrackingRepository : Repository<Data.Databases.OnlineSyncData.OrderDelTracking>, IOrderDelTrackingRepository
{
private readonly OnlineSyncDataContext _context;
public OrderDelTrackingRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

