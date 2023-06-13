namespace Data.Repositories.Tpfsystem
{
public class VSyncStockHistoryRepository : Repository<Data.Databases.Tpfsystem.VSyncStockHistory>, IVSyncStockHistoryRepository
{
private readonly TpfsystemContext _context;
public VSyncStockHistoryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

