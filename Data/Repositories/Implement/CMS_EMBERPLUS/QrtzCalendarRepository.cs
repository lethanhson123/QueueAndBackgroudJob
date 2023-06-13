namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzCalendarRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzCalendar>, IQrtzCalendarRepository
{
private readonly CmsEmberplusContext _context;
public QrtzCalendarRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

