namespace Data.Repositories.Tpfsystem
{
public class VCaReportValidationPlayerProductRepository : Repository<Data.Databases.Tpfsystem.VCaReportValidationPlayerProduct>, IVCaReportValidationPlayerProductRepository
{
private readonly TpfsystemContext _context;
public VCaReportValidationPlayerProductRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

