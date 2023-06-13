namespace Data.Repositories.Csversion1
{
public class CaConsetRepository : Repository<Data.Databases.Csversion1.CaConset>, ICaConsetRepository
{
private readonly Csversion1Context _context;
public CaConsetRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

