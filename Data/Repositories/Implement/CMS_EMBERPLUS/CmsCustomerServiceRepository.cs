namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsCustomerServiceRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsCustomerService>, ICmsCustomerServiceRepository
{
private readonly CmsEmberplusContext _context;
public CmsCustomerServiceRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

