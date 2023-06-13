namespace Data.Repositories.CMS_EMBERPLUS
{
public class OrderNotificationRepository : Repository<Data.Databases.CMS_EMBERPLUS.OrderNotification>, IOrderNotificationRepository
{
private readonly CmsEmberplusContext _context;
public OrderNotificationRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

