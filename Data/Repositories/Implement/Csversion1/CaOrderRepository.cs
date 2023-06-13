namespace Data.Repositories.Csversion1
{
public class CaOrderRepository : Repository<Data.Databases.Csversion1.CaOrder>, ICaOrderRepository
{
private readonly Csversion1Context _context;
public CaOrderRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

