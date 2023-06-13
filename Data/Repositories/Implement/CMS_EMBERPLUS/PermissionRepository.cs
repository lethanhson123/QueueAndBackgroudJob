namespace Data.Repositories.CMS_EMBERPLUS
{
public class PermissionRepository : Repository<Data.Databases.CMS_EMBERPLUS.Permission>, IPermissionRepository
{
private readonly CmsEmberplusContext _context;
public PermissionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

