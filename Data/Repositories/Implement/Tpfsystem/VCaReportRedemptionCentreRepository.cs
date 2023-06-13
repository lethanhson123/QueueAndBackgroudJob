namespace Data.Repositories.Tpfsystem
{
public class VCaReportRedemptionCentreRepository : Repository<Data.Databases.Tpfsystem.VCaReportRedemptionCentre>, IVCaReportRedemptionCentreRepository
{
private readonly TpfsystemContext _context;
public VCaReportRedemptionCentreRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

