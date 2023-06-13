namespace Data.Repositories.CMS_EMBERPLUS
{
public class CustomerServiceRepository : Repository<Data.Databases.CMS_EMBERPLUS.CustomerService>, ICustomerServiceRepository
{
private readonly CmsEmberplusContext _context;
public CustomerServiceRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

