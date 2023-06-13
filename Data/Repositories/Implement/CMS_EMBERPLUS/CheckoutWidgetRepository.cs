namespace Data.Repositories.CMS_EMBERPLUS
{
public class CheckoutWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.CheckoutWidget>, ICheckoutWidgetRepository
{
private readonly CmsEmberplusContext _context;
public CheckoutWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

