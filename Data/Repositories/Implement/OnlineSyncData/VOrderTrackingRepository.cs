namespace Data.Repositories.OnlineSyncData
{
public class VOrderTrackingRepository : Repository<Data.Databases.OnlineSyncData.VOrderTracking>, IVOrderTrackingRepository
{
private readonly OnlineSyncDataContext _context;
public VOrderTrackingRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

