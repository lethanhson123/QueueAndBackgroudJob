namespace Data.Repositories.Csversion1
{
public class CaSchoolUserStatusBak201909013Repository : Repository<Data.Databases.Csversion1.CaSchoolUserStatusBak201909013>, ICaSchoolUserStatusBak201909013Repository
{
private readonly Csversion1Context _context;
public CaSchoolUserStatusBak201909013Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

