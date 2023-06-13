namespace Data.Repositories.Csversion1
{
public class CaSchoolOrganisationStatusBakup20201203Repository : Repository<Data.Databases.Csversion1.CaSchoolOrganisationStatusBakup20201203>, ICaSchoolOrganisationStatusBakup20201203Repository
{
private readonly Csversion1Context _context;
public CaSchoolOrganisationStatusBakup20201203Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

