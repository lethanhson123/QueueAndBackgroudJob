namespace Data.Repositories.Csversion1
{
public class UserSchoolCheckRepository : Repository<Data.Databases.Csversion1.UserSchoolCheck>, IUserSchoolCheckRepository
{
private readonly Csversion1Context _context;
public UserSchoolCheckRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

