namespace Data.Repositories.Csversion1
{
public class CaStateSchoolRepository : Repository<Data.Databases.Csversion1.CaStateSchool>, ICaStateSchoolRepository
{
private readonly Csversion1Context _context;
public CaStateSchoolRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

