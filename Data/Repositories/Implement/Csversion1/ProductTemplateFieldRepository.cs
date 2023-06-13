namespace Data.Repositories.Csversion1
{
public class ProductTemplateFieldRepository : Repository<Data.Databases.Csversion1.ProductTemplateField>, IProductTemplateFieldRepository
{
private readonly Csversion1Context _context;
public ProductTemplateFieldRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

