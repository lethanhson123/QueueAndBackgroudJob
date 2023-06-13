namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsCounterRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsCounter>, ICmsCounterRepository
{
private readonly CmsEmberplusContext _context;
public CmsCounterRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

