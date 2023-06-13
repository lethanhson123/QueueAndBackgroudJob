namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsConfigurationUiScreenRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationUiScreen>, ICmsConfigurationUiScreenRepository
{
private readonly CmsEmberplusContext _context;
public CmsConfigurationUiScreenRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

