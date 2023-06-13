namespace Data.Repositories.Tpfsystem
{
public class VCaReportOrderSummaryRepository : Repository<Data.Databases.Tpfsystem.VCaReportOrderSummary>, IVCaReportOrderSummaryRepository
{
private readonly TpfsystemContext _context;
public VCaReportOrderSummaryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

