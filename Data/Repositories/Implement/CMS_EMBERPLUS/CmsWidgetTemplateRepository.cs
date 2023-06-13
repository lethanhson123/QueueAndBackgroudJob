namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsWidgetTemplateRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsWidgetTemplate>, ICmsWidgetTemplateRepository
{
private readonly CmsEmberplusContext _context;
public CmsWidgetTemplateRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

