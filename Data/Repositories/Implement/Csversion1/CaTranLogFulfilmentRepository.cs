namespace Data.Repositories.Csversion1
{
public class CaTranLogFulfilmentRepository : Repository<Data.Databases.Csversion1.CaTranLogFulfilment>, ICaTranLogFulfilmentRepository
{
private readonly Csversion1Context _context;
public CaTranLogFulfilmentRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

