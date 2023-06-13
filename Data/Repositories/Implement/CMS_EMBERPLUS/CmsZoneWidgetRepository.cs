namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsZoneWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsZoneWidget>, ICmsZoneWidgetRepository
{
private readonly CmsEmberplusContext _context;
public CmsZoneWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

