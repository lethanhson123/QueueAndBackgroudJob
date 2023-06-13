namespace Data.Repositories.OnlineSyncData
{
public class ClientCheckingRepository : Repository<Data.Databases.OnlineSyncData.ClientChecking>, IClientCheckingRepository
{
private readonly OnlineSyncDataContext _context;
public ClientCheckingRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

