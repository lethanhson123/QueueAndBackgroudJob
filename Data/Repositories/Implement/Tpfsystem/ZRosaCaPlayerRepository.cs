namespace Data.Repositories.Tpfsystem
{
public class ZRosaCaPlayerRepository : Repository<Data.Databases.Tpfsystem.ZRosaCaPlayer>, IZRosaCaPlayerRepository
{
private readonly TpfsystemContext _context;
public ZRosaCaPlayerRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

