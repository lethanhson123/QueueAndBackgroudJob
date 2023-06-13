namespace Data.Repositories.Tpfsystem
{
public class VCaReportRedemptionShoolRepository : Repository<Data.Databases.Tpfsystem.VCaReportRedemptionShool>, IVCaReportRedemptionShoolRepository
{
private readonly TpfsystemContext _context;
public VCaReportRedemptionShoolRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

