namespace Data.Repositories.Csversion1
{
public class CaSchoolOrgContactBakUpdateOrgIdRepository : Repository<Data.Databases.Csversion1.CaSchoolOrgContactBakUpdateOrgId>, ICaSchoolOrgContactBakUpdateOrgIdRepository
{
private readonly Csversion1Context _context;
public CaSchoolOrgContactBakUpdateOrgIdRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

