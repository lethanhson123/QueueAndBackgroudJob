namespace Data.Repositories.CMS_EMBERPLUS
{
public class ContentViewRepository : Repository<Data.Databases.CMS_EMBERPLUS.ContentView>, IContentViewRepository
{
private readonly CmsEmberplusContext _context;
public ContentViewRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

