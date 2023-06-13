namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductPackedItemRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductPackedItem>, IProductPackedItemRepository
{
private readonly CmsEmberplusContext _context;
public ProductPackedItemRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

