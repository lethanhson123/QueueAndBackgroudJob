namespace Data.Repositories.OnlineSyncData
{
public class VOrderTrackingV2Repository : Repository<Data.Databases.OnlineSyncData.VOrderTrackingV2>, IVOrderTrackingV2Repository
{
private readonly OnlineSyncDataContext _context;
public VOrderTrackingV2Repository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

