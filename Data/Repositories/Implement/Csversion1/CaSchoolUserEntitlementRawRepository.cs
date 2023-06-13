namespace Data.Repositories.Csversion1
{
public class CaSchoolUserEntitlementRawRepository : Repository<Data.Databases.Csversion1.CaSchoolUserEntitlementRaw>, ICaSchoolUserEntitlementRawRepository
{
private readonly Csversion1Context _context;
public CaSchoolUserEntitlementRawRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

