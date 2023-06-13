namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzPausedTriggerGrpRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzPausedTriggerGrp>, IQrtzPausedTriggerGrpRepository
{
private readonly CmsEmberplusContext _context;
public QrtzPausedTriggerGrpRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

