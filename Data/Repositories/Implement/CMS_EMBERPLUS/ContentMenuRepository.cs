namespace Data.Repositories.CMS_EMBERPLUS
{
public class ContentMenuRepository : Repository<Data.Databases.CMS_EMBERPLUS.ContentMenu>, IContentMenuRepository
{
private readonly CmsEmberplusContext _context;
public ContentMenuRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

