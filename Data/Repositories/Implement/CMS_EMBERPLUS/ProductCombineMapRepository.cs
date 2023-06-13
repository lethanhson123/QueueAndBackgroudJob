namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductCombineMapRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductCombineMap>, IProductCombineMapRepository
{
private readonly CmsEmberplusContext _context;
public ProductCombineMapRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

