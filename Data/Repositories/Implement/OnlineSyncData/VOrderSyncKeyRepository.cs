namespace Data.Repositories.OnlineSyncData
{
public class VOrderSyncKeyRepository : Repository<Data.Databases.OnlineSyncData.VOrderSyncKey>, IVOrderSyncKeyRepository
{
private readonly OnlineSyncDataContext _context;
public VOrderSyncKeyRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

