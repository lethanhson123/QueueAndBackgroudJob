namespace Data.Repositories.Tpfsystem
{
public class CaTrackingInfoRepository : Repository<Data.Databases.Tpfsystem.CaTrackingInfo>, ICaTrackingInfoRepository
{
private readonly TpfsystemContext _context;
public CaTrackingInfoRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

