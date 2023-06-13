namespace Data.Repositories.Csversion1
{
public class TagRepository : Repository<Data.Databases.Csversion1.Tag>, ITagRepository
{
private readonly Csversion1Context _context;
public TagRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

