namespace Data.Repositories.Csversion1
{
public class ZUpdatePlayHqidRepository : Repository<Data.Databases.Csversion1.ZUpdatePlayHqid>, IZUpdatePlayHqidRepository
{
private readonly Csversion1Context _context;
public ZUpdatePlayHqidRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

