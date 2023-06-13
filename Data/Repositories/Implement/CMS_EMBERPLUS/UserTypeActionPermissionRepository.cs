namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserTypeActionPermissionRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserTypeActionPermission>, IUserTypeActionPermissionRepository
{
private readonly CmsEmberplusContext _context;
public UserTypeActionPermissionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

