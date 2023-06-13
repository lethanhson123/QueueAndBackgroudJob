namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpOfferTrackingDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpOfferTrackingDetail>, IImpOfferTrackingDetailRepository
{
private readonly CmsEmberplusContext _context;
public ImpOfferTrackingDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

