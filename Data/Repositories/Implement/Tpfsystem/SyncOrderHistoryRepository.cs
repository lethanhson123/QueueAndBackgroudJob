namespace Data.Repositories.Tpfsystem
{
public class SyncOrderHistoryRepository : Repository<Data.Databases.Tpfsystem.SyncOrderHistory>, ISyncOrderHistoryRepository
{
private readonly TpfsystemContext _context;
public SyncOrderHistoryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

