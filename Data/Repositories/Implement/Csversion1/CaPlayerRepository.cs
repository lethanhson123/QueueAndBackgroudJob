namespace Data.Repositories.Csversion1
{
public class CaPlayerRepository : Repository<Data.Databases.Csversion1.CaPlayer>, ICaPlayerRepository
{
private readonly Csversion1Context _context;
public CaPlayerRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

