namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsLinkeditorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsLinkeditor>, ICmsLinkeditorRepository
{
private readonly CmsEmberplusContext _context;
public CmsLinkeditorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

