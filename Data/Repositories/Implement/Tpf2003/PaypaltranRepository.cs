namespace Data.Repositories.Tpf2003
{
public class PaypaltranRepository : Repository<Data.Databases.Tpf2003.Paypaltran>, IPaypaltranRepository
{
private readonly Tpf2003Context _context;
public PaypaltranRepository(Tpf2003Context context) : base(context)
{
_context = context;
}
}
}

