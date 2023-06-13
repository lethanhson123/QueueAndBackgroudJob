namespace Data.Repositories.Csversion1
{
public class VCafindUserRepository : Repository<Data.Databases.Csversion1.VCafindUser>, IVCafindUserRepository
{
private readonly Csversion1Context _context;
public VCafindUserRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

