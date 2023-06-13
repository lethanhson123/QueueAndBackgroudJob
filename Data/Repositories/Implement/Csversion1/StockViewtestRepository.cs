namespace Data.Repositories.Csversion1
{
public class StockViewtestRepository : Repository<Data.Databases.Csversion1.StockViewtest>, IStockViewtestRepository
{
private readonly Csversion1Context _context;
public StockViewtestRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

