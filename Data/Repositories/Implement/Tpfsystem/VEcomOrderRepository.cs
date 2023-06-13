namespace Data.Repositories.Tpfsystem
{
public class VEcomOrderRepository : Repository<Data.Databases.Tpfsystem.VEcomOrder>, IVEcomOrderRepository
{
private readonly TpfsystemContext _context;
public VEcomOrderRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

