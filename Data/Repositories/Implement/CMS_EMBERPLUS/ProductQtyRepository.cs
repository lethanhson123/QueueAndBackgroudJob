namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductQtyRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductQty>, IProductQtyRepository
{
private readonly CmsEmberplusContext _context;
public ProductQtyRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

