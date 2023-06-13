namespace Data.Repositories.Tpfsystem
{
public class VCaReportOrderSummaryDetailstestRepository : Repository<Data.Databases.Tpfsystem.VCaReportOrderSummaryDetailstest>, IVCaReportOrderSummaryDetailstestRepository
{
private readonly TpfsystemContext _context;
public VCaReportOrderSummaryDetailstestRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

