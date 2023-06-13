namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductPriceRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductPrice>, IProductPriceRepository
{
private readonly CmsEmberplusContext _context;
public ProductPriceRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

