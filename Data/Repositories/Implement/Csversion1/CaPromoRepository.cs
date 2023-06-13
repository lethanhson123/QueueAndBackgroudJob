namespace Data.Repositories.Csversion1
{
public class CaPromoRepository : Repository<Data.Databases.Csversion1.CaPromo>, ICaPromoRepository
{
private readonly Csversion1Context _context;
public CaPromoRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

