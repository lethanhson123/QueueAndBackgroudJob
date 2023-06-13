namespace Data.Repositories.Tpfsystem
{
public class VCaReportSaleProductRepository : Repository<Data.Databases.Tpfsystem.VCaReportSaleProduct>, IVCaReportSaleProductRepository
{
private readonly TpfsystemContext _context;
public VCaReportSaleProductRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

