namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductFavoriteRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductFavorite>, IProductFavoriteRepository
{
private readonly CmsEmberplusContext _context;
public ProductFavoriteRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

