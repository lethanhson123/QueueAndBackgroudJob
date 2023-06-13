namespace Data.Repositories.ExternalServices
{
public class TokenRepository : Repository<Data.Databases.ExternalServices.Token>, ITokenRepository
{
private readonly ExternalServicesContext _context;
public TokenRepository(ExternalServicesContext context) : base(context)
{
_context = context;
}
}
}

