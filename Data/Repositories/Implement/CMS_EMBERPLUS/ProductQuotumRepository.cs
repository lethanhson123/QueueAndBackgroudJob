namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductQuotumRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductQuotum>, IProductQuotumRepository
{
private readonly CmsEmberplusContext _context;
public ProductQuotumRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

