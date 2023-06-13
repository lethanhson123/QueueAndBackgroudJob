namespace Data.Repositories.Csversion1
{
public class CaSchoolOrganisationStatusBakUpdateOrgIdRepository : Repository<Data.Databases.Csversion1.CaSchoolOrganisationStatusBakUpdateOrgId>, ICaSchoolOrganisationStatusBakUpdateOrgIdRepository
{
private readonly Csversion1Context _context;
public CaSchoolOrganisationStatusBakUpdateOrgIdRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

