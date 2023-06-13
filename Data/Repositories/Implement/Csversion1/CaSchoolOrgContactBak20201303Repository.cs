namespace Data.Repositories.Csversion1
{
public class CaSchoolOrgContactBak20201303Repository : Repository<Data.Databases.Csversion1.CaSchoolOrgContactBak20201303>, ICaSchoolOrgContactBak20201303Repository
{
private readonly Csversion1Context _context;
public CaSchoolOrgContactBak20201303Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

