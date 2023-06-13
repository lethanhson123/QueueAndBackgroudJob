namespace Data.Repositories.Csversion1
{
public class StockCheckRepository : Repository<Data.Databases.Csversion1.StockCheck>, IStockCheckRepository
{
private readonly Csversion1Context _context;
public StockCheckRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

