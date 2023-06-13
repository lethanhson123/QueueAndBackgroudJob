namespace Data.Repositories.Csversion1
{
public class ZUpdateResetRepository : Repository<Data.Databases.Csversion1.ZUpdateReset>, IZUpdateResetRepository
{
private readonly Csversion1Context _context;
public ZUpdateResetRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

