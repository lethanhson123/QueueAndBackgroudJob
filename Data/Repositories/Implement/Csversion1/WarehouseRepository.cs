namespace Data.Repositories.Csversion1
{
public class WarehouseRepository : Repository<Data.Databases.Csversion1.Warehouse>, IWarehouseRepository
{
private readonly Csversion1Context _context;
public WarehouseRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

