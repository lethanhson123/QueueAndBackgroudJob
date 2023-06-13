namespace Data.Repositories.Csversion1
{
public class VCashowbblRepository : Repository<Data.Databases.Csversion1.VCashowbbl>, IVCashowbblRepository
{
private readonly Csversion1Context _context;
public VCashowbblRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

