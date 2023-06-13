namespace Data.Repositories.OnlineSyncData
{
public class AccountClaimRepository : Repository<Data.Databases.OnlineSyncData.AccountClaim>, IAccountClaimRepository
{
private readonly OnlineSyncDataContext _context;
public AccountClaimRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

