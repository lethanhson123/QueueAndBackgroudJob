namespace Data.Repositories.Csversion1
{
public class ProductPriceRepository : Repository<Data.Databases.Csversion1.ProductPrice>, IProductPriceRepository
{
private readonly Csversion1Context _context;
public ProductPriceRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

