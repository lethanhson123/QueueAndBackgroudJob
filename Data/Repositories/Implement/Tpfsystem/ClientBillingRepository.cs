namespace Data.Repositories.Tpfsystem
{
public class ClientBillingRepository : Repository<Data.Databases.Tpfsystem.ClientBilling>, IClientBillingRepository
{
private readonly TpfsystemContext _context;
public ClientBillingRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

