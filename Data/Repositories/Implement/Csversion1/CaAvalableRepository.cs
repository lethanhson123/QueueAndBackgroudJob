namespace Data.Repositories.Csversion1
{
public class CaAvalableRepository : Repository<Data.Databases.Csversion1.CaAvalable>, ICaAvalableRepository
{
private readonly Csversion1Context _context;
public CaAvalableRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

