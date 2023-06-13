namespace Data.Repositories.Tpfsystem
{
public class OcDeliveryOrderRepository : Repository<Data.Databases.Tpfsystem.OcDeliveryOrder>, IOcDeliveryOrderRepository
{
private readonly TpfsystemContext _context;
public OcDeliveryOrderRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

