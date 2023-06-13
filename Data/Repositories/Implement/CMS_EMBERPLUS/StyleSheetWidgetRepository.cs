namespace Data.Repositories.CMS_EMBERPLUS
{
public class StyleSheetWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.StyleSheetWidget>, IStyleSheetWidgetRepository
{
private readonly CmsEmberplusContext _context;
public StyleSheetWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

