namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductCombineAttributeRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductCombineAttribute>, IProductCombineAttributeRepository
{
private readonly CmsEmberplusContext _context;
public ProductCombineAttributeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

