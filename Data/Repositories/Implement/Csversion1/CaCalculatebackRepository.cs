namespace Data.Repositories.Csversion1
{
public class CaCalculatebackRepository : Repository<Data.Databases.Csversion1.CaCalculateback>, ICaCalculatebackRepository
{
private readonly Csversion1Context _context;
public CaCalculatebackRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

