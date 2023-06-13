namespace Data.Repositories.Csversion1
{
public class PlayHqproductRefRepository : Repository<Data.Databases.Csversion1.PlayHqproductRef>, IPlayHqproductRefRepository
{
private readonly Csversion1Context _context;
public PlayHqproductRefRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

