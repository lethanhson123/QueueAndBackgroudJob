namespace Data.Repositories.Csversion1
{
public class ProductPricesgroupcaRepository : Repository<Data.Databases.Csversion1.ProductPricesgroupca>, IProductPricesgroupcaRepository
{
private readonly Csversion1Context _context;
public ProductPricesgroupcaRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

