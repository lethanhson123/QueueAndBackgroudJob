namespace Data.Repositories.CMS_EMBERPLUS
{
public class CheckoutPaymentRepository : Repository<Data.Databases.CMS_EMBERPLUS.CheckoutPayment>, ICheckoutPaymentRepository
{
private readonly CmsEmberplusContext _context;
public CheckoutPaymentRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

