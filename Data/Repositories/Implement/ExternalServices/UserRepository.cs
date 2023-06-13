namespace Data.Repositories.ExternalServices
{
public class UserRepository : Repository<Data.Databases.ExternalServices.User>, IUserRepository
{
private readonly ExternalServicesContext _context;
public UserRepository(ExternalServicesContext context) : base(context)
{
_context = context;
}
}
}

