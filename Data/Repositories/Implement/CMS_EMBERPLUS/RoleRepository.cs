namespace Data.Repositories.CMS_EMBERPLUS
{
public class RoleRepository : Repository<Data.Databases.CMS_EMBERPLUS.Role>, IRoleRepository
{
private readonly CmsEmberplusContext _context;
public RoleRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

