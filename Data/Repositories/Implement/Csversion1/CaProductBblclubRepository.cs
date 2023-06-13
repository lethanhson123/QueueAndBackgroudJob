namespace Data.Repositories.Csversion1
{
public class CaProductBblclubRepository : Repository<Data.Databases.Csversion1.CaProductBblclub>, ICaProductBblclubRepository
{
private readonly Csversion1Context _context;
public CaProductBblclubRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

