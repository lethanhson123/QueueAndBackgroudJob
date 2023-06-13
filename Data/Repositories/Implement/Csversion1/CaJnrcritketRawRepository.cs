namespace Data.Repositories.Csversion1
{
public class CaJnrcritketRawRepository : Repository<Data.Databases.Csversion1.CaJnrcritketRaw>, ICaJnrcritketRawRepository
{
private readonly Csversion1Context _context;
public CaJnrcritketRawRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

