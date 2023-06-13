namespace Data.Repositories.Csversion1
{
public class VCaproductsizeRepository : Repository<Data.Databases.Csversion1.VCaproductsize>, IVCaproductsizeRepository
{
private readonly Csversion1Context _context;
public VCaproductsizeRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

