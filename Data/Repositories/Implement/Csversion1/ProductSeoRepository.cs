namespace Data.Repositories.Csversion1
{
public class ProductSeoRepository : Repository<Data.Databases.Csversion1.ProductSeo>, IProductSeoRepository
{
private readonly Csversion1Context _context;
public ProductSeoRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

