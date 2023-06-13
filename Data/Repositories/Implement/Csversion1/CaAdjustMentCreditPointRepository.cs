namespace Data.Repositories.Csversion1
{
public class CaAdjustMentCreditPointRepository : Repository<Data.Databases.Csversion1.CaAdjustMentCreditPoint>, ICaAdjustMentCreditPointRepository
{
private readonly Csversion1Context _context;
public CaAdjustMentCreditPointRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

