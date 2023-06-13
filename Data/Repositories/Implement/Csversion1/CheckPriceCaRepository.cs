namespace Data.Repositories.Csversion1
{
public class CheckPriceCaRepository : Repository<Data.Databases.Csversion1.CheckPriceCa>, ICheckPriceCaRepository
{
private readonly Csversion1Context _context;
public CheckPriceCaRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

