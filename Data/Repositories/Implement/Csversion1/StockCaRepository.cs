namespace Data.Repositories.Csversion1
{
public class StockCaRepository : Repository<Data.Databases.Csversion1.StockCa>, IStockCaRepository
{
private readonly Csversion1Context _context;
public StockCaRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

