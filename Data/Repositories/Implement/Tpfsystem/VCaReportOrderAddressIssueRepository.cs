namespace Data.Repositories.Tpfsystem
{
public class VCaReportOrderAddressIssueRepository : Repository<Data.Databases.Tpfsystem.VCaReportOrderAddressIssue>, IVCaReportOrderAddressIssueRepository
{
private readonly TpfsystemContext _context;
public VCaReportOrderAddressIssueRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

