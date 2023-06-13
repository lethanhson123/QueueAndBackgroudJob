namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsEmailRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsEmail>, ICmsEmailRepository
{
private readonly CmsEmberplusContext _context;
public CmsEmailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

