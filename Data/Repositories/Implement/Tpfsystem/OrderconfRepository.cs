namespace Data.Repositories.Tpfsystem
{
public class OrderconfRepository : Repository<Data.Databases.Tpfsystem.Orderconf>, IOrderconfRepository
{
private readonly TpfsystemContext _context;
public OrderconfRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

