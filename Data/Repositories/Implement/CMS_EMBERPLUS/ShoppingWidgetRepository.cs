namespace Data.Repositories.CMS_EMBERPLUS
{
public class ShoppingWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.ShoppingWidget>, IShoppingWidgetRepository
{
private readonly CmsEmberplusContext _context;
public ShoppingWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

