namespace Data.Repositories.Csversion1
{
public class ProductTemplateFieldOptionRepository : Repository<Data.Databases.Csversion1.ProductTemplateFieldOption>, IProductTemplateFieldOptionRepository
{
private readonly Csversion1Context _context;
public ProductTemplateFieldOptionRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

