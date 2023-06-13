namespace Data.Repositories.Csversion1
{
public class Sheet1Repository : Repository<Data.Databases.Csversion1.Sheet1>, ISheet1Repository
{
private readonly Csversion1Context _context;
public Sheet1Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

