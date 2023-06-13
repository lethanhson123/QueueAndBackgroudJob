namespace Data.Repositories.Csversion1
{
public class CaOrganisationRepository : Repository<Data.Databases.Csversion1.CaOrganisation>, ICaOrganisationRepository
{
private readonly Csversion1Context _context;
public CaOrganisationRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

