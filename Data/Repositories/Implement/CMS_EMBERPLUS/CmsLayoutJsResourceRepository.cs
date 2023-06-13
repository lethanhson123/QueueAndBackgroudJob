namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsLayoutJsResourceRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsLayoutJsResource>, ICmsLayoutJsResourceRepository
{
private readonly CmsEmberplusContext _context;
public CmsLayoutJsResourceRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

