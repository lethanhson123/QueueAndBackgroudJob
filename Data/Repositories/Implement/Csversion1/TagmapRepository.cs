namespace Data.Repositories.Csversion1
{
public class TagmapRepository : Repository<Data.Databases.Csversion1.Tagmap>, ITagmapRepository
{
private readonly Csversion1Context _context;
public TagmapRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

