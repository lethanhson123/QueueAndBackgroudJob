namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpOfferTrackingRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpOfferTracking>, IImpOfferTrackingRepository
{
private readonly CmsEmberplusContext _context;
public ImpOfferTrackingRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

