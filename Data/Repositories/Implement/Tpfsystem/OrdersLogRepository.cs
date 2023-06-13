namespace Data.Repositories.Tpfsystem
{
public class OrdersLogRepository : Repository<Data.Databases.Tpfsystem.OrdersLog>, IOrdersLogRepository
{
private readonly TpfsystemContext _context;
public OrdersLogRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

