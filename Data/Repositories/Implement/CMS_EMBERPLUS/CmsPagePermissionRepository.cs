namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsPagePermissionRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsPagePermission>, ICmsPagePermissionRepository
{
private readonly CmsEmberplusContext _context;
public CmsPagePermissionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

