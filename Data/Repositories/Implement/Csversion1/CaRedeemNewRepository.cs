namespace Data.Repositories.Csversion1
{
public class CaRedeemNewRepository : Repository<Data.Databases.Csversion1.CaRedeemNew>, ICaRedeemNewRepository
{
private readonly Csversion1Context _context;
public CaRedeemNewRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

