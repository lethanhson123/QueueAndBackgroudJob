namespace Data.Repositories.Tpfsystem
{
public class OrderSummaryReportRepository : Repository<Data.Databases.Tpfsystem.OrderSummaryReport>, IOrderSummaryReportRepository
{
private readonly TpfsystemContext _context;
public OrderSummaryReportRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

