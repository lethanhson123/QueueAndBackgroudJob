namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductPriceBakRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductPriceBak>, IProductPriceBakRepository
{
private readonly CmsEmberplusContext _context;
public ProductPriceBakRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

