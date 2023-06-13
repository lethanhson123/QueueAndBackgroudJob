namespace Data.Repositories.Csversion1
{
public class CatalogueSeoRepository : Repository<Data.Databases.Csversion1.CatalogueSeo>, ICatalogueSeoRepository
{
private readonly Csversion1Context _context;
public CatalogueSeoRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

