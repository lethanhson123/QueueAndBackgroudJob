namespace Data.Repositories.Csversion1
{
public class VCaDetailsPacknNoneQtyRepository : Repository<Data.Databases.Csversion1.VCaDetailsPacknNoneQty>, IVCaDetailsPacknNoneQtyRepository
{
private readonly Csversion1Context _context;
public VCaDetailsPacknNoneQtyRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

