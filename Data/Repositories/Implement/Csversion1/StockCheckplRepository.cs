namespace Data.Repositories.Csversion1
{
public class StockCheckplRepository : Repository<Data.Databases.Csversion1.StockCheckpl>, IStockCheckplRepository
{
private readonly Csversion1Context _context;
public StockCheckplRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

