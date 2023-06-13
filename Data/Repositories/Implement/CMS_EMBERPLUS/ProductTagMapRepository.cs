namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductTagMapRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductTagMap>, IProductTagMapRepository
{
private readonly CmsEmberplusContext _context;
public ProductTagMapRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

