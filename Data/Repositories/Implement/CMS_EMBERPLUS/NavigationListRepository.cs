namespace Data.Repositories.CMS_EMBERPLUS
{
public class NavigationListRepository : Repository<Data.Databases.CMS_EMBERPLUS.NavigationList>, INavigationListRepository
{
private readonly CmsEmberplusContext _context;
public NavigationListRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

