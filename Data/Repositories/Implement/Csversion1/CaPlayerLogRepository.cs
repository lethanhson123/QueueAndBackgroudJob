namespace Data.Repositories.Csversion1
{
public class CaPlayerLogRepository : Repository<Data.Databases.Csversion1.CaPlayerLog>, ICaPlayerLogRepository
{
private readonly Csversion1Context _context;
public CaPlayerLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

