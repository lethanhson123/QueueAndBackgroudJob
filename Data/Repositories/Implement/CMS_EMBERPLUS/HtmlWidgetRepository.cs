namespace Data.Repositories.CMS_EMBERPLUS
{
public class HtmlWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.HtmlWidget>, IHtmlWidgetRepository
{
private readonly CmsEmberplusContext _context;
public HtmlWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

