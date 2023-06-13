namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsLayoutCssResourceRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsLayoutCssResource>, ICmsLayoutCssResourceRepository
{
private readonly CmsEmberplusContext _context;
public CmsLayoutCssResourceRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

