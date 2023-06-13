namespace Data.Repositories.Csversion1
{
public class VCaDetailsPackRepository : Repository<Data.Databases.Csversion1.VCaDetailsPack>, IVCaDetailsPackRepository
{
private readonly Csversion1Context _context;
public VCaDetailsPackRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

