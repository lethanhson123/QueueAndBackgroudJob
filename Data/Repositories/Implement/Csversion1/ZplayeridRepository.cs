namespace Data.Repositories.Csversion1
{
public class ZplayeridRepository : Repository<Data.Databases.Csversion1.Zplayerid>, IZplayeridRepository
{
private readonly Csversion1Context _context;
public ZplayeridRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

