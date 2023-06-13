namespace Data.Repositories.CMS_EMBERPLUS
{
public class CheckoutShippingRepository : Repository<Data.Databases.CMS_EMBERPLUS.CheckoutShipping>, ICheckoutShippingRepository
{
private readonly CmsEmberplusContext _context;
public CheckoutShippingRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

