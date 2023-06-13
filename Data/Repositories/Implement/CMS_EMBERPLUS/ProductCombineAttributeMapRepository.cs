namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductCombineAttributeMapRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductCombineAttributeMap>, IProductCombineAttributeMapRepository
{
private readonly CmsEmberplusContext _context;
public ProductCombineAttributeMapRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

