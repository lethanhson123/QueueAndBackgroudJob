namespace Data.Repositories.Csversion1
{
public class ComSyncLogRepository : Repository<Data.Databases.Csversion1.ComSyncLog>, IComSyncLogRepository
{
private readonly Csversion1Context _context;
public ComSyncLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

