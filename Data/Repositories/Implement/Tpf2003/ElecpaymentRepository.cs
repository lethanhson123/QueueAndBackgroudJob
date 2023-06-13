namespace Data.Repositories.Tpf2003
{
public class ElecpaymentRepository : Repository<Data.Databases.Tpf2003.Elecpayment>, IElecpaymentRepository
{
private readonly Tpf2003Context _context;
public ElecpaymentRepository(Tpf2003Context context) : base(context)
{
_context = context;
}
}
}

