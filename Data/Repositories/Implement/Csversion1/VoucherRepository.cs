namespace Data.Repositories.Csversion1
{
public class VoucherRepository : Repository<Data.Databases.Csversion1.Voucher>, IVoucherRepository
{
private readonly Csversion1Context _context;
public VoucherRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

