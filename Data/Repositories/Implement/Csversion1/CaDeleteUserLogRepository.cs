namespace Data.Repositories.Csversion1
{
public class CaDeleteUserLogRepository : Repository<Data.Databases.Csversion1.CaDeleteUserLog>, ICaDeleteUserLogRepository
{
private readonly Csversion1Context _context;
public CaDeleteUserLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

