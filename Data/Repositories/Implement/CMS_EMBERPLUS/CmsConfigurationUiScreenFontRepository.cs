namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsConfigurationUiScreenFontRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationUiScreenFont>, ICmsConfigurationUiScreenFontRepository
{
private readonly CmsEmberplusContext _context;
public CmsConfigurationUiScreenFontRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

