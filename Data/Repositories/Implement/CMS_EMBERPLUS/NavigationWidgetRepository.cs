namespace Data.Repositories.CMS_EMBERPLUS
{
public class NavigationWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.NavigationWidget>, INavigationWidgetRepository
{
private readonly CmsEmberplusContext _context;
public NavigationWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

