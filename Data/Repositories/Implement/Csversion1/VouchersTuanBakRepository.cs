namespace Data.Repositories.Csversion1
{
public class VouchersTuanBakRepository : Repository<Data.Databases.Csversion1.VouchersTuanBak>, IVouchersTuanBakRepository
{
private readonly Csversion1Context _context;
public VouchersTuanBakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

