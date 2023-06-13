namespace Data.Repositories.CMS_EMBERPLUS
{
public class WidgetGroupTemplateRepository : Repository<Data.Databases.CMS_EMBERPLUS.WidgetGroupTemplate>, IWidgetGroupTemplateRepository
{
private readonly CmsEmberplusContext _context;
public WidgetGroupTemplateRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

