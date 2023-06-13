namespace Data.Repositories.OnlineSyncData
{
public class AccountRepository : Repository<Data.Databases.OnlineSyncData.Account>, IAccountRepository
{
private readonly OnlineSyncDataContext _context;
public AccountRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

