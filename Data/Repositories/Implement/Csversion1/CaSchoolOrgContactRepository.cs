namespace Data.Repositories.Csversion1
{
public class CaSchoolOrgContactRepository : Repository<Data.Databases.Csversion1.CaSchoolOrgContact>, ICaSchoolOrgContactRepository
{
private readonly Csversion1Context _context;
public CaSchoolOrgContactRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

