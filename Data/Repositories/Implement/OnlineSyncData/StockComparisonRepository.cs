namespace Data.Repositories.OnlineSyncData
{
public class StockComparisonRepository : Repository<Data.Databases.OnlineSyncData.StockComparison>, IStockComparisonRepository
{
private readonly OnlineSyncDataContext _context;
public StockComparisonRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

