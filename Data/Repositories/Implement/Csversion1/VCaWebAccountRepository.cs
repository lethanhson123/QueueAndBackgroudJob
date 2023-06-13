namespace Data.Repositories.Csversion1
{
public class VCaWebAccountRepository : Repository<Data.Databases.Csversion1.VCaWebAccount>, IVCaWebAccountRepository
{
private readonly Csversion1Context _context;
public VCaWebAccountRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

