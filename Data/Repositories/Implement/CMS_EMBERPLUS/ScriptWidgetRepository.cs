namespace Data.Repositories.CMS_EMBERPLUS
{
public class ScriptWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.ScriptWidget>, IScriptWidgetRepository
{
private readonly CmsEmberplusContext _context;
public ScriptWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

