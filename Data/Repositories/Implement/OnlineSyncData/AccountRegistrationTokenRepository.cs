namespace Data.Repositories.OnlineSyncData
{
public class AccountRegistrationTokenRepository : Repository<Data.Databases.OnlineSyncData.AccountRegistrationToken>, IAccountRegistrationTokenRepository
{
private readonly OnlineSyncDataContext _context;
public AccountRegistrationTokenRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

