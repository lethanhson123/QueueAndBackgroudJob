namespace Data.Repositories.TPFServices
{
public class RoleRepository : Repository<Data.Databases.TPFServices.Role>, IRoleRepository
{
private readonly TpfservicesContext _context;
public RoleRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

