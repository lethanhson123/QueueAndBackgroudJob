namespace Data.Repositories.Csversion1
{
public class CaSchoolUserOrganisationRawRepository : Repository<Data.Databases.Csversion1.CaSchoolUserOrganisationRaw>, ICaSchoolUserOrganisationRawRepository
{
private readonly Csversion1Context _context;
public CaSchoolUserOrganisationRawRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

