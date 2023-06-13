namespace Data.Repositories.Csversion1
{
public class VCaDetailsPackPublicRepository : Repository<Data.Databases.Csversion1.VCaDetailsPackPublic>, IVCaDetailsPackPublicRepository
{
private readonly Csversion1Context _context;
public VCaDetailsPackPublicRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

