namespace Data.Repositories.Csversion1
{
public class VCaProductProfileProductPricegroupRepository : Repository<Data.Databases.Csversion1.VCaProductProfileProductPricegroup>, IVCaProductProfileProductPricegroupRepository
{
private readonly Csversion1Context _context;
public VCaProductProfileProductPricegroupRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

