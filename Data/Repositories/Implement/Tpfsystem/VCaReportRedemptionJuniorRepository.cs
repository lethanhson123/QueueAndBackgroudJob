namespace Data.Repositories.Tpfsystem
{
public class VCaReportRedemptionJuniorRepository : Repository<Data.Databases.Tpfsystem.VCaReportRedemptionJunior>, IVCaReportRedemptionJuniorRepository
{
private readonly TpfsystemContext _context;
public VCaReportRedemptionJuniorRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

