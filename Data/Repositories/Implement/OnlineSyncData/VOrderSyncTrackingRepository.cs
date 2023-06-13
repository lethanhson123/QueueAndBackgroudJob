namespace Data.Repositories.OnlineSyncData
{
public class VOrderSyncTrackingRepository : Repository<Data.Databases.OnlineSyncData.VOrderSyncTracking>, IVOrderSyncTrackingRepository
{
private readonly OnlineSyncDataContext _context;
public VOrderSyncTrackingRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

