namespace Data.Repositories.Csversion1
{
public class VCagetpropackdynamicRepository : Repository<Data.Databases.Csversion1.VCagetpropackdynamic>, IVCagetpropackdynamicRepository
{
private readonly Csversion1Context _context;
public VCagetpropackdynamicRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

