namespace Data.Repositories.Tpfsystem
{
public class SyncStockHistoryRepository : Repository<Data.Databases.Tpfsystem.SyncStockHistory>, ISyncStockHistoryRepository
{
private readonly TpfsystemContext _context;
public SyncStockHistoryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

