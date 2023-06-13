namespace Data.Repositories.Tpfsystem
{
public class WebPermissionRepository : Repository<Data.Databases.Tpfsystem.WebPermission>, IWebPermissionRepository
{
private readonly TpfsystemContext _context;
public WebPermissionRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

