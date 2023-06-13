namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductAttributeDescriptionRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductAttributeDescription>, IProductAttributeDescriptionRepository
{
private readonly CmsEmberplusContext _context;
public ProductAttributeDescriptionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

