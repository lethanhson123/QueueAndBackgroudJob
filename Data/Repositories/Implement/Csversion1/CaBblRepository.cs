namespace Data.Repositories.Csversion1
{
public class CaBblRepository : Repository<Data.Databases.Csversion1.CaBbl>, ICaBblRepository
{
private readonly Csversion1Context _context;
public CaBblRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

