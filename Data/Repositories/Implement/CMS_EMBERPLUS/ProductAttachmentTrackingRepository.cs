namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductAttachmentTrackingRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductAttachmentTracking>, IProductAttachmentTrackingRepository
{
private readonly CmsEmberplusContext _context;
public ProductAttachmentTrackingRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

