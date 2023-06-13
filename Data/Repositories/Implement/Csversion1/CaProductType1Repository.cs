namespace Data.Repositories.Csversion1
{
public class CaProductType1Repository : Repository<Data.Databases.Csversion1.CaProductType1>, ICaProductType1Repository
{
private readonly Csversion1Context _context;
public CaProductType1Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

