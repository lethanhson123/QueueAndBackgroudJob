namespace Data.Repositories.Csversion1
{
public class CaAvalableTBakRepository : Repository<Data.Databases.Csversion1.CaAvalableTBak>, ICaAvalableTBakRepository
{
private readonly Csversion1Context _context;
public CaAvalableTBakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

