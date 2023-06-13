namespace Data.Repositories.Csversion1
{
public class Vouchersbak20200428Repository : Repository<Data.Databases.Csversion1.Vouchersbak20200428>, IVouchersbak20200428Repository
{
private readonly Csversion1Context _context;
public Vouchersbak20200428Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

