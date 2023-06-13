namespace Data.Repositories.Csversion1
{
public class StockViewRepository : Repository<Data.Databases.Csversion1.StockView>, IStockViewRepository
{
private readonly Csversion1Context _context;
public StockViewRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

