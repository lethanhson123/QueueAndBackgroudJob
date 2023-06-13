namespace Data.Repositories.Tpfsystem
{
public class WebRoleRepository : Repository<Data.Databases.Tpfsystem.WebRole>, IWebRoleRepository
{
private readonly TpfsystemContext _context;
public WebRoleRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

