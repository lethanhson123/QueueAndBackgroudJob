namespace Data.Repositories.Csversion1
{
public class VoucherHistoryBackAddCreditRepository : Repository<Data.Databases.Csversion1.VoucherHistoryBackAddCredit>, IVoucherHistoryBackAddCreditRepository
{
private readonly Csversion1Context _context;
public VoucherHistoryBackAddCreditRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

