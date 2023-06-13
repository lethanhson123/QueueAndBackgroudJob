namespace Data.Repositories.Tpf2003
{
public class PayTransLogRepository : Repository<Data.Databases.Tpf2003.PayTransLog>, IPayTransLogRepository
{
private readonly Tpf2003Context _context;
public PayTransLogRepository(Tpf2003Context context) : base(context)
{
_context = context;
}
}
}

