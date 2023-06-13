namespace Data.Repositories.OnlineSyncData
{
public class AccountRoleRepository : Repository<Data.Databases.OnlineSyncData.AccountRole>, IAccountRoleRepository
{
private readonly OnlineSyncDataContext _context;
public AccountRoleRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

