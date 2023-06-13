namespace Data.Repositories.Csversion1
{
public class CheckOrgeRepository : Repository<Data.Databases.Csversion1.CheckOrge>, ICheckOrgeRepository
{
private readonly Csversion1Context _context;
public CheckOrgeRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

