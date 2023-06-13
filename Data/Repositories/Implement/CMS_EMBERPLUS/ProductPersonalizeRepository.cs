namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductPersonalizeRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductPersonalize>, IProductPersonalizeRepository
{
private readonly CmsEmberplusContext _context;
public ProductPersonalizeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

