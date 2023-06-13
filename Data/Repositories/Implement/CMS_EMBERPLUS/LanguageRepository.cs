namespace Data.Repositories.CMS_EMBERPLUS
{
public class LanguageRepository : Repository<Data.Databases.CMS_EMBERPLUS.Language>, ILanguageRepository
{
private readonly CmsEmberplusContext _context;
public LanguageRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

