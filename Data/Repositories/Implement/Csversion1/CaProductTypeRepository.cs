namespace Data.Repositories.Csversion1
{
public class CaProductTypeRepository : Repository<Data.Databases.Csversion1.CaProductType>, ICaProductTypeRepository
{
private readonly Csversion1Context _context;
public CaProductTypeRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

