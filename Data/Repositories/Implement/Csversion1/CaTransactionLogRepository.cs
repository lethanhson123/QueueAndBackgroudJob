namespace Data.Repositories.Csversion1
{
public class CaTransactionLogRepository : Repository<Data.Databases.Csversion1.CaTransactionLog>, ICaTransactionLogRepository
{
private readonly Csversion1Context _context;
public CaTransactionLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

