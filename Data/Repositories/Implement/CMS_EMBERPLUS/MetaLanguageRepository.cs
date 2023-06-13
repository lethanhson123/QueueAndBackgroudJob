namespace Data.Repositories.CMS_EMBERPLUS
{
public class MetaLanguageRepository : Repository<Data.Databases.CMS_EMBERPLUS.MetaLanguage>, IMetaLanguageRepository
{
private readonly CmsEmberplusContext _context;
public MetaLanguageRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

