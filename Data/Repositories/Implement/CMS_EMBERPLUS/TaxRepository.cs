namespace Data.Repositories.CMS_EMBERPLUS
{
public class TaxRepository : Repository<Data.Databases.CMS_EMBERPLUS.Tax>, ITaxRepository
{
private readonly CmsEmberplusContext _context;
public TaxRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

