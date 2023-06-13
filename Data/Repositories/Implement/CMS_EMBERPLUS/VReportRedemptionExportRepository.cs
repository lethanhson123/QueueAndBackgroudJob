namespace Data.Repositories.CMS_EMBERPLUS
{
public class VReportRedemptionExportRepository : Repository<Data.Databases.CMS_EMBERPLUS.VReportRedemptionExport>, IVReportRedemptionExportRepository
{
private readonly CmsEmberplusContext _context;
public VReportRedemptionExportRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

