namespace Data.Repositories.Csversion1
{
public class CatVoucherRepository : Repository<Data.Databases.Csversion1.CatVoucher>, ICatVoucherRepository
{
private readonly Csversion1Context _context;
public CatVoucherRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

