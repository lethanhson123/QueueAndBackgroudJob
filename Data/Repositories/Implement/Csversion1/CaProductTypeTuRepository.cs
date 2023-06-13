namespace Data.Repositories.Csversion1
{
public class CaProductTypeTuRepository : Repository<Data.Databases.Csversion1.CaProductTypeTu>, ICaProductTypeTuRepository
{
private readonly Csversion1Context _context;
public CaProductTypeTuRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

