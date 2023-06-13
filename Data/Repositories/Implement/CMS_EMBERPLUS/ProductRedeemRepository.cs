namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductRedeemRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductRedeem>, IProductRedeemRepository
{
private readonly CmsEmberplusContext _context;
public ProductRedeemRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

