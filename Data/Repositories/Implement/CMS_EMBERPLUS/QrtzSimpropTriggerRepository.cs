namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzSimpropTriggerRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzSimpropTrigger>, IQrtzSimpropTriggerRepository
{
private readonly CmsEmberplusContext _context;
public QrtzSimpropTriggerRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

