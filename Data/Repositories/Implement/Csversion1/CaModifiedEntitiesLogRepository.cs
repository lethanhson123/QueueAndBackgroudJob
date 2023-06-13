namespace Data.Repositories.Csversion1
{
public class CaModifiedEntitiesLogRepository : Repository<Data.Databases.Csversion1.CaModifiedEntitiesLog>, ICaModifiedEntitiesLogRepository
{
private readonly Csversion1Context _context;
public CaModifiedEntitiesLogRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

