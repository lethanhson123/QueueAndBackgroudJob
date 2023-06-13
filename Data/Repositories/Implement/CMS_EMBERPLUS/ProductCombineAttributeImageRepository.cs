namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductCombineAttributeImageRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductCombineAttributeImage>, IProductCombineAttributeImageRepository
{
private readonly CmsEmberplusContext _context;
public ProductCombineAttributeImageRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

