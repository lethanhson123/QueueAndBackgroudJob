namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzFiredTriggerRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzFiredTrigger>, IQrtzFiredTriggerRepository
{
private readonly CmsEmberplusContext _context;
public QrtzFiredTriggerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

