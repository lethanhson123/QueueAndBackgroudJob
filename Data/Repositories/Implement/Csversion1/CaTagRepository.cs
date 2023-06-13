namespace Data.Repositories.Csversion1
{
public class CaTagRepository : Repository<Data.Databases.Csversion1.CaTag>, ICaTagRepository
{
private readonly Csversion1Context _context;
public CaTagRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

