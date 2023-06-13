namespace Data.Repositories.Csversion1
{
public class VSwiWebAccountRepository : Repository<Data.Databases.Csversion1.VSwiWebAccount>, IVSwiWebAccountRepository
{
private readonly Csversion1Context _context;
public VSwiWebAccountRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

