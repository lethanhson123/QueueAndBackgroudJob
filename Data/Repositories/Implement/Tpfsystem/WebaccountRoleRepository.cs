namespace Data.Repositories.Tpfsystem
{
public class WebaccountRoleRepository : Repository<Data.Databases.Tpfsystem.WebaccountRole>, IWebaccountRoleRepository
{
private readonly TpfsystemContext _context;
public WebaccountRoleRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

