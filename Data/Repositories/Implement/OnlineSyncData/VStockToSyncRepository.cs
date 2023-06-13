namespace Data.Repositories.OnlineSyncData
{
public class VStockToSyncRepository : Repository<Data.Databases.OnlineSyncData.VStockToSync>, IVStockToSyncRepository
{
private readonly OnlineSyncDataContext _context;
public VStockToSyncRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

