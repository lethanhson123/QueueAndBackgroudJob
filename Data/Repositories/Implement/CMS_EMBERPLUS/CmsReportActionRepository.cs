namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsReportActionRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsReportAction>, ICmsReportActionRepository
{
private readonly CmsEmberplusContext _context;
public CmsReportActionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

