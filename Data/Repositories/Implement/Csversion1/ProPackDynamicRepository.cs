namespace Data.Repositories.Csversion1
{
public class ProPackDynamicRepository : Repository<Data.Databases.Csversion1.ProPackDynamic>, IProPackDynamicRepository
{
private readonly Csversion1Context _context;
public ProPackDynamicRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

