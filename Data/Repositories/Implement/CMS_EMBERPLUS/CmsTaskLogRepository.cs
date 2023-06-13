namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsTaskLogRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsTaskLog>, ICmsTaskLogRepository
{
private readonly CmsEmberplusContext _context;
public CmsTaskLogRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

