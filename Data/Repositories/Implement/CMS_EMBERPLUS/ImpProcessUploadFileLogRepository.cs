namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpProcessUploadFileLogRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpProcessUploadFileLog>, IImpProcessUploadFileLogRepository
{
private readonly CmsEmberplusContext _context;
public ImpProcessUploadFileLogRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

