namespace Data.Repositories.Tpfsystem
{
public class VSyncHistoryRepository : Repository<Data.Databases.Tpfsystem.VSyncHistory>, IVSyncHistoryRepository
{
private readonly TpfsystemContext _context;
public VSyncHistoryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

