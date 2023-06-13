namespace Data.Repositories.Csversion1
{
public class CaSchoolOrganisationStatusRepository : Repository<Data.Databases.Csversion1.CaSchoolOrganisationStatus>, ICaSchoolOrganisationStatusRepository
{
private readonly Csversion1Context _context;
public CaSchoolOrganisationStatusRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

