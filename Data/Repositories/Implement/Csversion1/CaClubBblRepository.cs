namespace Data.Repositories.Csversion1
{
public class CaClubBblRepository : Repository<Data.Databases.Csversion1.CaClubBbl>, ICaClubBblRepository
{
private readonly Csversion1Context _context;
public CaClubBblRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

