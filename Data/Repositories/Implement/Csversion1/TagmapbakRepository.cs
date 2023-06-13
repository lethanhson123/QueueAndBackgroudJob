namespace Data.Repositories.Csversion1
{
public class TagmapbakRepository : Repository<Data.Databases.Csversion1.Tagmapbak>, ITagmapbakRepository
{
private readonly Csversion1Context _context;
public TagmapbakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

