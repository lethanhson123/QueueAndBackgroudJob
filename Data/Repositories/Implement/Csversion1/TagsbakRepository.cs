namespace Data.Repositories.Csversion1
{
public class TagsbakRepository : Repository<Data.Databases.Csversion1.Tagsbak>, ITagsbakRepository
{
private readonly Csversion1Context _context;
public TagsbakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

