namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsReportRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsReport>, ICmsReportRepository
{
private readonly CmsEmberplusContext _context;
public CmsReportRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

