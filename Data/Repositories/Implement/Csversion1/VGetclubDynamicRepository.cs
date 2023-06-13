namespace Data.Repositories.Csversion1
{
public class VGetclubDynamicRepository : Repository<Data.Databases.Csversion1.VGetclubDynamic>, IVGetclubDynamicRepository
{
private readonly Csversion1Context _context;
public VGetclubDynamicRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

