namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsConfigurationColorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationColor>, ICmsConfigurationColorRepository
{
private readonly CmsEmberplusContext _context;
public CmsConfigurationColorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

