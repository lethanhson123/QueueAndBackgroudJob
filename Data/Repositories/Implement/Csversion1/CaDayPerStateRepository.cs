namespace Data.Repositories.Csversion1
{
public class CaDayPerStateRepository : Repository<Data.Databases.Csversion1.CaDayPerState>, ICaDayPerStateRepository
{
private readonly Csversion1Context _context;
public CaDayPerStateRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

