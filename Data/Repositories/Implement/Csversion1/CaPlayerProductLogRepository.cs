namespace Data.Repositories.Csversion1
{
public class CaPlayerProductLogRepository : Repository<Data.Databases.Csversion1.CaPlayerProductLog>, ICaPlayerProductLogRepository
{
private readonly Csversion1Context _context;
public CaPlayerProductLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

