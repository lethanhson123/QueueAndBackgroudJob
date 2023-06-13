namespace Data.Repositories.Csversion1
{
public class CaCalculateRepository : Repository<Data.Databases.Csversion1.CaCalculate>, ICaCalculateRepository
{
private readonly Csversion1Context _context;
public CaCalculateRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

