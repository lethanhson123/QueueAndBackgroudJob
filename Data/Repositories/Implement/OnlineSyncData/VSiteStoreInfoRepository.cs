namespace Data.Repositories.OnlineSyncData
{
public class VSiteStoreInfoRepository : Repository<Data.Databases.OnlineSyncData.VSiteStoreInfo>, IVSiteStoreInfoRepository
{
private readonly OnlineSyncDataContext _context;
public VSiteStoreInfoRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

