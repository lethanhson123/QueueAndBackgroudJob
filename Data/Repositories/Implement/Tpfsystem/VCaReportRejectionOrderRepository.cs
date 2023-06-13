namespace Data.Repositories.Tpfsystem
{
public class VCaReportRejectionOrderRepository : Repository<Data.Databases.Tpfsystem.VCaReportRejectionOrder>, IVCaReportRejectionOrderRepository
{
private readonly TpfsystemContext _context;
public VCaReportRejectionOrderRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

