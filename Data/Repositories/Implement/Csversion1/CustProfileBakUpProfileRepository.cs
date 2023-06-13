namespace Data.Repositories.Csversion1
{
public class CustProfileBakUpProfileRepository : Repository<Data.Databases.Csversion1.CustProfileBakUpProfile>, ICustProfileBakUpProfileRepository
{
private readonly Csversion1Context _context;
public CustProfileBakUpProfileRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

