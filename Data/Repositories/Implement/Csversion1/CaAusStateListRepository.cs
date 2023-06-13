namespace Data.Repositories.Csversion1
{
public class CaAusStateListRepository : Repository<Data.Databases.Csversion1.CaAusStateList>, ICaAusStateListRepository
{
private readonly Csversion1Context _context;
public CaAusStateListRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

