namespace Data.Repositories.Csversion1
{
public class ProductTemplateRepository : Repository<Data.Databases.Csversion1.ProductTemplate>, IProductTemplateRepository
{
private readonly Csversion1Context _context;
public ProductTemplateRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

