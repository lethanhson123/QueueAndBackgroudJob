namespace Data.Repositories.ExternalServices
{
public class RoleRepository : Repository<Data.Databases.ExternalServices.Role>, IRoleRepository
{
private readonly ExternalServicesContext _context;
public RoleRepository(ExternalServicesContext context) : base(context)
{
_context = context;
}
}
}

