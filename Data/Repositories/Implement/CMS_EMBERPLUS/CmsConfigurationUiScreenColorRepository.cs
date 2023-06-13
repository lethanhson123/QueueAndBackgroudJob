namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsConfigurationUiScreenColorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationUiScreenColor>, ICmsConfigurationUiScreenColorRepository
{
private readonly CmsEmberplusContext _context;
public CmsConfigurationUiScreenColorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

