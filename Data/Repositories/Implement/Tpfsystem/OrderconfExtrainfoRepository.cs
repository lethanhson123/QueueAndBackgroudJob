namespace Data.Repositories.Tpfsystem
{
public class OrderconfExtrainfoRepository : Repository<Data.Databases.Tpfsystem.OrderconfExtrainfo>, IOrderconfExtrainfoRepository
{
private readonly TpfsystemContext _context;
public OrderconfExtrainfoRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

