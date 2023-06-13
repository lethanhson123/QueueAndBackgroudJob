namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsHtmleditorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsHtmleditor>, ICmsHtmleditorRepository
{
private readonly CmsEmberplusContext _context;
public CmsHtmleditorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

