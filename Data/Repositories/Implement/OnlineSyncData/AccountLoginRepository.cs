namespace Data.Repositories.OnlineSyncData
{
public class AccountLoginRepository : Repository<Data.Databases.OnlineSyncData.AccountLogin>, IAccountLoginRepository
{
private readonly OnlineSyncDataContext _context;
public AccountLoginRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

