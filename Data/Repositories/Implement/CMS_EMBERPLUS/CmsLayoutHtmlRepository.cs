namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsLayoutHtmlRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsLayoutHtml>, ICmsLayoutHtmlRepository
{
private readonly CmsEmberplusContext _context;
public CmsLayoutHtmlRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

