namespace Data.Repositories.Tpfsystem
{
public class CaTrackingDetailRepository : Repository<Data.Databases.Tpfsystem.CaTrackingDetail>, ICaTrackingDetailRepository
{
private readonly TpfsystemContext _context;
public CaTrackingDetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

