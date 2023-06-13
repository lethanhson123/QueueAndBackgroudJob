namespace Data.Repositories.Csversion1
{
public class CaRedeemRepository : Repository<Data.Databases.Csversion1.CaRedeem>, ICaRedeemRepository
{
private readonly Csversion1Context _context;
public CaRedeemRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

