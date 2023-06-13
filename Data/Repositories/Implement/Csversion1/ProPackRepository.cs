namespace Data.Repositories.Csversion1
{
public class ProPackRepository : Repository<Data.Databases.Csversion1.ProPack>, IProPackRepository
{
private readonly Csversion1Context _context;
public ProPackRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

