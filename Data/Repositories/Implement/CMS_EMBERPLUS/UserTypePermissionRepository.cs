namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserTypePermissionRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserTypePermission>, IUserTypePermissionRepository
{
private readonly CmsEmberplusContext _context;
public UserTypePermissionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

