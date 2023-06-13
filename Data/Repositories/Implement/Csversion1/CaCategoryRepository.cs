namespace Data.Repositories.Csversion1
{
public class CaCategoryRepository : Repository<Data.Databases.Csversion1.CaCategory>, ICaCategoryRepository
{
private readonly Csversion1Context _context;
public CaCategoryRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

