namespace Data.Repositories.CMS_EMBERPLUS
{
public class VReportRedemptionRepository : Repository<Data.Databases.CMS_EMBERPLUS.VReportRedemption>, IVReportRedemptionRepository
{
private readonly CmsEmberplusContext _context;
public VReportRedemptionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

