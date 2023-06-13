namespace Data.Repositories.Csversion1
{
public class CaTypeDetailRepository : Repository<Data.Databases.Csversion1.CaTypeDetail>, ICaTypeDetailRepository
{
private readonly Csversion1Context _context;
public CaTypeDetailRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

