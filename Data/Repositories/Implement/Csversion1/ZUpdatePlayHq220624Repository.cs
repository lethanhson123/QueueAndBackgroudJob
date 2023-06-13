namespace Data.Repositories.Csversion1
{
public class ZUpdatePlayHq220624Repository : Repository<Data.Databases.Csversion1.ZUpdatePlayHq220624>, IZUpdatePlayHq220624Repository
{
private readonly Csversion1Context _context;
public ZUpdatePlayHq220624Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

