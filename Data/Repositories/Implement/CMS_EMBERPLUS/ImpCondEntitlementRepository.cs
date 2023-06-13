namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpCondEntitlementRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpCondEntitlement>, IImpCondEntitlementRepository
{
private readonly CmsEmberplusContext _context;
public ImpCondEntitlementRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

