namespace Data.Repositories.TPFServices
{
public class TestTableRepository : Repository<Data.Databases.TPFServices.TestTable>, ITestTableRepository
{
private readonly TpfservicesContext _context;
public TestTableRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

