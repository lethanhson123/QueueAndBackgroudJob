namespace Data.Repositories.Csversion1
{
public class ProductProfileRepository : Repository<Data.Databases.Csversion1.ProductProfile>, IProductProfileRepository
{
private readonly Csversion1Context _context;
public ProductProfileRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

