namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzLockRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzLock>, IQrtzLockRepository
{
private readonly CmsEmberplusContext _context;
public QrtzLockRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

