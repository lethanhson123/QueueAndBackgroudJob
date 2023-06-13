namespace Data.Repositories.CMS_EMBERPLUS
{
public class WebOrderDeliveryTrackingDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.WebOrderDeliveryTrackingDetail>, IWebOrderDeliveryTrackingDetailRepository
{
private readonly CmsEmberplusContext _context;
public WebOrderDeliveryTrackingDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

