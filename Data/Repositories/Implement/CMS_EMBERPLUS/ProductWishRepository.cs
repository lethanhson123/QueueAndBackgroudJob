namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductWishRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductWish>, IProductWishRepository
{
private readonly CmsEmberplusContext _context;
public ProductWishRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

