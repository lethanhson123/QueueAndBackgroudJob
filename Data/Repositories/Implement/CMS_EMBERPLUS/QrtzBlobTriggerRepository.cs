namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzBlobTriggerRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzBlobTrigger>, IQrtzBlobTriggerRepository
{
private readonly CmsEmberplusContext _context;
public QrtzBlobTriggerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

