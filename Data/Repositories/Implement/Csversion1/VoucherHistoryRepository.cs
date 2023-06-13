namespace Data.Repositories.Csversion1
{
public class VoucherHistoryRepository : Repository<Data.Databases.Csversion1.VoucherHistory>, IVoucherHistoryRepository
{
private readonly Csversion1Context _context;
public VoucherHistoryRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

