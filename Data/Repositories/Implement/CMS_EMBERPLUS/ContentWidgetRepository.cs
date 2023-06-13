namespace Data.Repositories.CMS_EMBERPLUS
{
public class ContentWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.ContentWidget>, IContentWidgetRepository
{
private readonly CmsEmberplusContext _context;
public ContentWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

