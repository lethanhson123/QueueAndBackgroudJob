namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsLanguageRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsLanguage>, ICmsLanguageRepository
{
private readonly CmsEmberplusContext _context;
public CmsLanguageRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

