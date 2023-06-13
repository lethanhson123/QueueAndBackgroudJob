namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductLayerRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductLayer>, IProductLayerRepository
{
private readonly CmsEmberplusContext _context;
public ProductLayerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

