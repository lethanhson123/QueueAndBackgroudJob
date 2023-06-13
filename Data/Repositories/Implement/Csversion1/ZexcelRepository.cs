namespace Data.Repositories.Csversion1
{
public class ZexcelRepository : Repository<Data.Databases.Csversion1.Zexcel>, IZexcelRepository
{
private readonly Csversion1Context _context;
public ZexcelRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

