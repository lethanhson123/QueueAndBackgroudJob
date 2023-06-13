namespace Data.Repositories.Tpfsystem
{
public class OcDeliveryDetailRepository : Repository<Data.Databases.Tpfsystem.OcDeliveryDetail>, IOcDeliveryDetailRepository
{
private readonly TpfsystemContext _context;
public OcDeliveryDetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

