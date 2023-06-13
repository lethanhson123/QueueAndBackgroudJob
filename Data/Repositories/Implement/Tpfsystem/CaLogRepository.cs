namespace Data.Repositories.Tpfsystem
{
public class CaLogRepository : Repository<Data.Databases.Tpfsystem.CaLog>, ICaLogRepository
{
private readonly TpfsystemContext _context;
public CaLogRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

