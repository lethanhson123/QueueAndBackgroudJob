namespace Data.Repositories.CMS_EMBERPLUS
{
public class ContentViewFieldRepository : Repository<Data.Databases.CMS_EMBERPLUS.ContentViewField>, IContentViewFieldRepository
{
private readonly CmsEmberplusContext _context;
public ContentViewFieldRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

