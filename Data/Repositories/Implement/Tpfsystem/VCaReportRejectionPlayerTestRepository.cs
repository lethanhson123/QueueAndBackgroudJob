namespace Data.Repositories.Tpfsystem
{
public class VCaReportRejectionPlayerTestRepository : Repository<Data.Databases.Tpfsystem.VCaReportRejectionPlayerTest>, IVCaReportRejectionPlayerTestRepository
{
private readonly TpfsystemContext _context;
public VCaReportRejectionPlayerTestRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

