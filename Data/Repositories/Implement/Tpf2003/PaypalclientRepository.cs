namespace Data.Repositories.Tpf2003
{
public class PaypalclientRepository : Repository<Data.Databases.Tpf2003.Paypalclient>, IPaypalclientRepository
{
private readonly Tpf2003Context _context;
public PaypalclientRepository(Tpf2003Context context) : base(context)
{
_context = context;
}
}
}

