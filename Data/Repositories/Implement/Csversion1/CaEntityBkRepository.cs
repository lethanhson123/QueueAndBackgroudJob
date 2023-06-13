namespace Data.Repositories.Csversion1
{
public class CaEntityBkRepository : Repository<Data.Databases.Csversion1.CaEntityBk>, ICaEntityBkRepository
{
private readonly Csversion1Context _context;
public CaEntityBkRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

