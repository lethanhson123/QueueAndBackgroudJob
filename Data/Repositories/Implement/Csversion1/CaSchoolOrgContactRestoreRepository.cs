namespace Data.Repositories.Csversion1
{
public class CaSchoolOrgContactRestoreRepository : Repository<Data.Databases.Csversion1.CaSchoolOrgContactRestore>, ICaSchoolOrgContactRestoreRepository
{
private readonly Csversion1Context _context;
public CaSchoolOrgContactRestoreRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

