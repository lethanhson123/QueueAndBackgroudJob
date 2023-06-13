namespace Data.Repositories.Csversion1
{
public class CaProgramRepository : Repository<Data.Databases.Csversion1.CaProgram>, ICaProgramRepository
{
private readonly Csversion1Context _context;
public CaProgramRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

