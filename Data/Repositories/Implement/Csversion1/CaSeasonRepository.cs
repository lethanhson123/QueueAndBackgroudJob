namespace Data.Repositories.Csversion1
{
public class CaSeasonRepository : Repository<Data.Databases.Csversion1.CaSeason>, ICaSeasonRepository
{
private readonly Csversion1Context _context;
public CaSeasonRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

