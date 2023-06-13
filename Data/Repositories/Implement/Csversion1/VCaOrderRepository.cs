namespace Data.Repositories.Csversion1
{
public class VCaOrderRepository : Repository<Data.Databases.Csversion1.VCaOrder>, IVCaOrderRepository
{
private readonly Csversion1Context _context;
public VCaOrderRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

