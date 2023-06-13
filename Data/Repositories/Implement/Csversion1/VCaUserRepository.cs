namespace Data.Repositories.Csversion1
{
public class VCaUserRepository : Repository<Data.Databases.Csversion1.VCaUser>, IVCaUserRepository
{
private readonly Csversion1Context _context;
public VCaUserRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

