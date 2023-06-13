namespace Data.Repositories.Csversion1
{
public class CaPlayerProgramRepository : Repository<Data.Databases.Csversion1.CaPlayerProgram>, ICaPlayerProgramRepository
{
private readonly Csversion1Context _context;
public CaPlayerProgramRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

