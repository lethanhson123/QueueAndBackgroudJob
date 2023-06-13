namespace Data.Repositories.Csversion1
{
public class VCaProductProfileProductPriceRepository : Repository<Data.Databases.Csversion1.VCaProductProfileProductPrice>, IVCaProductProfileProductPriceRepository
{
private readonly Csversion1Context _context;
public VCaProductProfileProductPriceRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

