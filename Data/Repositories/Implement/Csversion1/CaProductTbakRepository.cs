namespace Data.Repositories.Csversion1
{
public class CaProductTbakRepository : Repository<Data.Databases.Csversion1.CaProductTbak>, ICaProductTbakRepository
{
private readonly Csversion1Context _context;
public CaProductTbakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

