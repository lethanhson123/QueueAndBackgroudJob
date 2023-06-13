namespace Data.Repositories.Csversion1
{
public class CaConditionUpdateTransIdRepository : Repository<Data.Databases.Csversion1.CaConditionUpdateTransId>, ICaConditionUpdateTransIdRepository
{
private readonly Csversion1Context _context;
public CaConditionUpdateTransIdRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

