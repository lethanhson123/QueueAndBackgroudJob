namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsEmailSampleRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsEmailSample>, ICmsEmailSampleRepository
{
private readonly CmsEmberplusContext _context;
public CmsEmailSampleRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

