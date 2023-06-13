namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductAttachmentRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductAttachment>, IProductAttachmentRepository
{
private readonly CmsEmberplusContext _context;
public ProductAttachmentRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

