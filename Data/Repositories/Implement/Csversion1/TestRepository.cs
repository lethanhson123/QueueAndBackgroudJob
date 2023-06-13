namespace Data.Repositories.Csversion1
{
public class TestRepository : Repository<Data.Databases.Csversion1.Test>, ITestRepository
{
private readonly Csversion1Context _context;
public TestRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

