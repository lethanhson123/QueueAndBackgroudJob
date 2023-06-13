namespace Data.Repositories.Csversion1
{
public class CaProductRepository : Repository<Data.Databases.Csversion1.CaProduct>, ICaProductRepository
{
private readonly Csversion1Context _context;
public CaProductRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

