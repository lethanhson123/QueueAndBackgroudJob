namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductTagRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductTag>, IProductTagRepository
{
private readonly CmsEmberplusContext _context;
public ProductTagRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

