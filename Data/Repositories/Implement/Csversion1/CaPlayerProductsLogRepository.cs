namespace Data.Repositories.Csversion1
{
public class CaPlayerProductsLogRepository : Repository<Data.Databases.Csversion1.CaPlayerProductsLog>, ICaPlayerProductsLogRepository
{
private readonly Csversion1Context _context;
public CaPlayerProductsLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

