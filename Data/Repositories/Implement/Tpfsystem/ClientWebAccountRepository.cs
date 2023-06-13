namespace Data.Repositories.Tpfsystem
{
public class ClientWebAccountRepository : Repository<Data.Databases.Tpfsystem.ClientWebAccount>, IClientWebAccountRepository
{
private readonly TpfsystemContext _context;
public ClientWebAccountRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

