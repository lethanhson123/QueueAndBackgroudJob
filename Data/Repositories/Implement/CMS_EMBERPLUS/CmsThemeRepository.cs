namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsThemeRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsTheme>, ICmsThemeRepository
{
private readonly CmsEmberplusContext _context;
public CmsThemeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

