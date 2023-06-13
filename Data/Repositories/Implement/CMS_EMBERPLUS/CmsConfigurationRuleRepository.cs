namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsConfigurationRuleRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationRule>, ICmsConfigurationRuleRepository
{
private readonly CmsEmberplusContext _context;
public CmsConfigurationRuleRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

