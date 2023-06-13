namespace Data.Repositories.ExternalServices
{
public class WebDomainRepository : Repository<Data.Databases.ExternalServices.WebDomain>, IWebDomainRepository
{
private readonly ExternalServicesContext _context;
public WebDomainRepository(ExternalServicesContext context) : base(context)
{
_context = context;
}
}
}

