namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductFilterRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductFilter>, IProductFilterRepository
{
private readonly CmsEmberplusContext _context;
public ProductFilterRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

