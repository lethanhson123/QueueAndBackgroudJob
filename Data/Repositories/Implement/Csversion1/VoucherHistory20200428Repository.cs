namespace Data.Repositories.Csversion1
{
public class VoucherHistory20200428Repository : Repository<Data.Databases.Csversion1.VoucherHistory20200428>, IVoucherHistory20200428Repository
{
private readonly Csversion1Context _context;
public VoucherHistory20200428Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

