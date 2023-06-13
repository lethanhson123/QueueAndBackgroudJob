namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductLayerDetailImageRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductLayerDetailImage>, IProductLayerDetailImageRepository
{
private readonly CmsEmberplusContext _context;
public ProductLayerDetailImageRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

