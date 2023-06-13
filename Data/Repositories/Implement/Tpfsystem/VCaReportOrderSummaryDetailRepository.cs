namespace Data.Repositories.Tpfsystem
{
public class VCaReportOrderSummaryDetailRepository : Repository<Data.Databases.Tpfsystem.VCaReportOrderSummaryDetail>, IVCaReportOrderSummaryDetailRepository
{
private readonly TpfsystemContext _context;
public VCaReportOrderSummaryDetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

