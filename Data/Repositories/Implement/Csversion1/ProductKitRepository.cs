namespace Data.Repositories.Csversion1
{
public class ProductKitRepository : Repository<Data.Databases.Csversion1.ProductKit>, IProductKitRepository
{
private readonly Csversion1Context _context;
public ProductKitRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

