namespace Data.Repositories.Csversion1
{
public class MatchingRepository : Repository<Data.Databases.Csversion1.Matching>, IMatchingRepository
{
private readonly Csversion1Context _context;
public MatchingRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

