namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsTaskScheduleLogRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsTaskScheduleLog>, ICmsTaskScheduleLogRepository
{
private readonly CmsEmberplusContext _context;
public CmsTaskScheduleLogRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

