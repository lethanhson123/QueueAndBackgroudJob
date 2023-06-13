namespace Data.Repositories.Csversion1
{
public class VCaGetbblRepository : Repository<Data.Databases.Csversion1.VCaGetbbl>, IVCaGetbblRepository
{
private readonly Csversion1Context _context;
public VCaGetbblRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

