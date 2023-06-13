namespace Data.Repositories.CMS_EMBERPLUS
{
public class WidgetGroupTemplateItemRepository : Repository<Data.Databases.CMS_EMBERPLUS.WidgetGroupTemplateItem>, IWidgetGroupTemplateItemRepository
{
private readonly CmsEmberplusContext _context;
public WidgetGroupTemplateItemRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

