namespace Data.Repositories.Csversion1
{
public class ProductTemplateMapRepository : Repository<Data.Databases.Csversion1.ProductTemplateMap>, IProductTemplateMapRepository
{
private readonly Csversion1Context _context;
public ProductTemplateMapRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

