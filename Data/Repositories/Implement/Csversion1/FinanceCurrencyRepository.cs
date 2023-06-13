namespace Data.Repositories.Csversion1
{
public class FinanceCurrencyRepository : Repository<Data.Databases.Csversion1.FinanceCurrency>, IFinanceCurrencyRepository
{
private readonly Csversion1Context _context;
public FinanceCurrencyRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

