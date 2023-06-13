namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsCountryRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsCountry>, ICmsCountryRepository
{
private readonly CmsEmberplusContext _context;
public CmsCountryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

