namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzTriggerRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzTrigger>, IQrtzTriggerRepository
{
private readonly CmsEmberplusContext _context;
public QrtzTriggerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

