namespace Data.Repositories.TestDB
{
public class PersonRepository : Repository<Data.Databases.TestDB.Person>, IPersonRepository
{
private readonly TestDbContext _context;
public PersonRepository(TestDbContext context) : base(context)
{
_context = context;
}
}
}

