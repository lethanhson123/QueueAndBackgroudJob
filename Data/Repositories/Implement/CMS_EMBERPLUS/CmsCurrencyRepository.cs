namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsCurrencyRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsCurrency>, ICmsCurrencyRepository
{
private readonly CmsEmberplusContext _context;
public CmsCurrencyRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

