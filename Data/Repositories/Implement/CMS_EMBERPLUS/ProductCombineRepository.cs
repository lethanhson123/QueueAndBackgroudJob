namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductCombineRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductCombine>, IProductCombineRepository
{
private readonly CmsEmberplusContext _context;
public ProductCombineRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

