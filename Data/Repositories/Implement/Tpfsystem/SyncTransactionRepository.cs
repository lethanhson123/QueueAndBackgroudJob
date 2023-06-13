namespace Data.Repositories.Tpfsystem
{
public class SyncTransactionRepository : Repository<Data.Databases.Tpfsystem.SyncTransaction>, ISyncTransactionRepository
{
private readonly TpfsystemContext _context;
public SyncTransactionRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

