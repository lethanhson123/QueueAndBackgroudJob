namespace Data.Repositories.CMS_EMBERPLUS
{
public class WidgetTemplateModeRepository : Repository<Data.Databases.CMS_EMBERPLUS.WidgetTemplateMode>, IWidgetTemplateModeRepository
{
private readonly CmsEmberplusContext _context;
public WidgetTemplateModeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

