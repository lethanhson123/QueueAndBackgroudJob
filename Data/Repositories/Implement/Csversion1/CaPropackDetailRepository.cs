namespace Data.Repositories.Csversion1
{
public class CaPropackDetailRepository : Repository<Data.Databases.Csversion1.CaPropackDetail>, ICaPropackDetailRepository
{
private readonly Csversion1Context _context;
public CaPropackDetailRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

