namespace Data.Repositories.Csversion1
{
public class CaProductTypeSubRepository : Repository<Data.Databases.Csversion1.CaProductTypeSub>, ICaProductTypeSubRepository
{
private readonly Csversion1Context _context;
public CaProductTypeSubRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

