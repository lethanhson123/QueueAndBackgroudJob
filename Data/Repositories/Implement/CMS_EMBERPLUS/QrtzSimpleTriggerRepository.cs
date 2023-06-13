namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzSimpleTriggerRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzSimpleTrigger>, IQrtzSimpleTriggerRepository
{
private readonly CmsEmberplusContext _context;
public QrtzSimpleTriggerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

