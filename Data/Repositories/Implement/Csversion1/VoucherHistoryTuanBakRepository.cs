namespace Data.Repositories.Csversion1
{
public class VoucherHistoryTuanBakRepository : Repository<Data.Databases.Csversion1.VoucherHistoryTuanBak>, IVoucherHistoryTuanBakRepository
{
private readonly Csversion1Context _context;
public VoucherHistoryTuanBakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

