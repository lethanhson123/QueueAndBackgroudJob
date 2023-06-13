namespace Data.Repositories.Tpfsystem
{
public class VCaReportRejectionPlayerRepository : Repository<Data.Databases.Tpfsystem.VCaReportRejectionPlayer>, IVCaReportRejectionPlayerRepository
{
private readonly TpfsystemContext _context;
public VCaReportRejectionPlayerRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

