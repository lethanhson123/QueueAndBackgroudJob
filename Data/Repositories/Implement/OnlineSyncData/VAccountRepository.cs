namespace Data.Repositories.OnlineSyncData
{
public class VAccountRepository : Repository<Data.Databases.OnlineSyncData.VAccount>, IVAccountRepository
{
private readonly OnlineSyncDataContext _context;
public VAccountRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

