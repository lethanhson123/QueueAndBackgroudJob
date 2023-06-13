namespace Data.Repositories.Csversion1
{
public class CaSchoolUserStatusRepository : Repository<Data.Databases.Csversion1.CaSchoolUserStatus>, ICaSchoolUserStatusRepository
{
private readonly Csversion1Context _context;
public CaSchoolUserStatusRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

