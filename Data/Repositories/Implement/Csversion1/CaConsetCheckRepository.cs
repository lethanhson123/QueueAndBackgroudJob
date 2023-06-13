namespace Data.Repositories.Csversion1
{
public class CaConsetCheckRepository : Repository<Data.Databases.Csversion1.CaConsetCheck>, ICaConsetCheckRepository
{
private readonly Csversion1Context _context;
public CaConsetCheckRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

