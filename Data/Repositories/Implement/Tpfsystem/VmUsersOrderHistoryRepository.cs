namespace Data.Repositories.Tpfsystem
{
public class VmUsersOrderHistoryRepository : Repository<Data.Databases.Tpfsystem.VmUsersOrderHistory>, IVmUsersOrderHistoryRepository
{
private readonly TpfsystemContext _context;
public VmUsersOrderHistoryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

