namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductFilterMapRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductFilterMap>, IProductFilterMapRepository
{
private readonly CmsEmberplusContext _context;
public ProductFilterMapRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

