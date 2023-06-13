namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsZoneRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsZone>, ICmsZoneRepository
{
private readonly CmsEmberplusContext _context;
public CmsZoneRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

