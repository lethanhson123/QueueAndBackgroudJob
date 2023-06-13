namespace Data.Repositories.Csversion1
{
public class CaPlayerProductRepository : Repository<Data.Databases.Csversion1.CaPlayerProduct>, ICaPlayerProductRepository
{
private readonly Csversion1Context _context;
public CaPlayerProductRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

