namespace Data.Repositories.Csversion1
{
public class ProductPricesBakRepository : Repository<Data.Databases.Csversion1.ProductPricesBak>, IProductPricesBakRepository
{
private readonly Csversion1Context _context;
public ProductPricesBakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

