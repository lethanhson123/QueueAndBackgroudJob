namespace Data.Repositories.Tpfsystem
{
public class VCaReportOrderNoBatSizeRepository : Repository<Data.Databases.Tpfsystem.VCaReportOrderNoBatSize>, IVCaReportOrderNoBatSizeRepository
{
private readonly TpfsystemContext _context;
public VCaReportOrderNoBatSizeRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

