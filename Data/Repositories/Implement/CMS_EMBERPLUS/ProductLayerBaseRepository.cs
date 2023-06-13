namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductLayerBaseRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductLayerBase>, IProductLayerBaseRepository
{
private readonly CmsEmberplusContext _context;
public ProductLayerBaseRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

