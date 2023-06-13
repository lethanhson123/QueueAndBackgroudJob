namespace Data.Repositories.CMS_EMBERPLUS
{
public class NavigationRepository : Repository<Data.Databases.CMS_EMBERPLUS.Navigation>, INavigationRepository
{
private readonly CmsEmberplusContext _context;
public NavigationRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

