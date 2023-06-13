namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzSchedulerStateRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzSchedulerState>, IQrtzSchedulerStateRepository
{
private readonly CmsEmberplusContext _context;
public QrtzSchedulerStateRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

