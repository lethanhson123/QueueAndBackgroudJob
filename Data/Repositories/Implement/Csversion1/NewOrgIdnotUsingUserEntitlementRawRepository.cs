namespace Data.Repositories.Csversion1
{
public class NewOrgIdnotUsingUserEntitlementRawRepository : Repository<Data.Databases.Csversion1.NewOrgIdnotUsingUserEntitlementRaw>, INewOrgIdnotUsingUserEntitlementRawRepository
{
private readonly Csversion1Context _context;
public NewOrgIdnotUsingUserEntitlementRawRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

