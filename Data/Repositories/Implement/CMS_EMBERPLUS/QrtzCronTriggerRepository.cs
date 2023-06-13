namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzCronTriggerRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzCronTrigger>, IQrtzCronTriggerRepository
{
private readonly CmsEmberplusContext _context;
public QrtzCronTriggerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

