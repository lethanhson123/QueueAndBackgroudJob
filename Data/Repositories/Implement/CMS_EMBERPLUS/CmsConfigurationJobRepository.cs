namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsConfigurationJobRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationJob>, ICmsConfigurationJobRepository
{
private readonly CmsEmberplusContext _context;
public CmsConfigurationJobRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

