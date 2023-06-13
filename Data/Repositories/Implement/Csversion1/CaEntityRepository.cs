namespace Data.Repositories.Csversion1
{
public class CaEntityRepository : Repository<Data.Databases.Csversion1.CaEntity>, ICaEntityRepository
{
private readonly Csversion1Context _context;
public CaEntityRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

