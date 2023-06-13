namespace Data.Repositories.Csversion1
{
public class CaProductTableRepository : Repository<Data.Databases.Csversion1.CaProductTable>, ICaProductTableRepository
{
private readonly Csversion1Context _context;
public CaProductTableRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

