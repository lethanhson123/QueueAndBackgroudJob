namespace Data.Repositories.Csversion1
{
public class VCaDetailsPackplRepository : Repository<Data.Databases.Csversion1.VCaDetailsPackpl>, IVCaDetailsPackplRepository
{
private readonly Csversion1Context _context;
public VCaDetailsPackplRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

