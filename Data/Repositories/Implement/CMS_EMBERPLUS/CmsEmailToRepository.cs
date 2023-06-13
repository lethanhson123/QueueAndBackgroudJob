namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsEmailToRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsEmailTo>, ICmsEmailToRepository
{
private readonly CmsEmberplusContext _context;
public CmsEmailToRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

