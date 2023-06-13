namespace Data.Repositories.Csversion1
{
public class CustProfileRepository : Repository<Data.Databases.Csversion1.CustProfile>, ICustProfileRepository
{
private readonly Csversion1Context _context;
public CustProfileRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

