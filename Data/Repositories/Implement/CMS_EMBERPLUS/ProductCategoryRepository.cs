namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductCategoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductCategory>, IProductCategoryRepository
{
private readonly CmsEmberplusContext _context;
public ProductCategoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

