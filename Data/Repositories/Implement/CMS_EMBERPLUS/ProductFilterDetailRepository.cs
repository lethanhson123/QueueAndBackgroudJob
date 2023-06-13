namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductFilterDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductFilterDetail>, IProductFilterDetailRepository
{
private readonly CmsEmberplusContext _context;
public ProductFilterDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

