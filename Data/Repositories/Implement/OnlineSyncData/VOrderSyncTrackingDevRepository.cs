namespace Data.Repositories.OnlineSyncData
{
public class VOrderSyncTrackingDevRepository : Repository<Data.Databases.OnlineSyncData.VOrderSyncTrackingDev>, IVOrderSyncTrackingDevRepository
{
private readonly OnlineSyncDataContext _context;
public VOrderSyncTrackingDevRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

