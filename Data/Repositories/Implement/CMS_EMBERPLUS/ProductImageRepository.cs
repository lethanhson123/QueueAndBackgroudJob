namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductImageRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductImage>, IProductImageRepository
{
private readonly CmsEmberplusContext _context;
public ProductImageRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

