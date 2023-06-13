namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpUploadFileLogRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpUploadFileLog>, IImpUploadFileLogRepository
{
private readonly CmsEmberplusContext _context;
public ImpUploadFileLogRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

