namespace Data.Repositories.TPFServices
{
public class UserRoleRepository : Repository<Data.Databases.TPFServices.UserRole>, IUserRoleRepository
{
private readonly TpfservicesContext _context;
public UserRoleRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

