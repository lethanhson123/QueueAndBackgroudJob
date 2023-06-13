namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductLayerDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductLayerDetail>, IProductLayerDetailRepository
{
private readonly CmsEmberplusContext _context;
public ProductLayerDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

