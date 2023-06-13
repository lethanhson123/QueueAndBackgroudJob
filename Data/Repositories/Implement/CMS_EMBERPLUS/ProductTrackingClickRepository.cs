namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductTrackingClickRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductTrackingClick>, IProductTrackingClickRepository
{
private readonly CmsEmberplusContext _context;
public ProductTrackingClickRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

