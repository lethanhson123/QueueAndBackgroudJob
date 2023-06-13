namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpCondEntitlementHistoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpCondEntitlementHistory>, IImpCondEntitlementHistoryRepository
{
private readonly CmsEmberplusContext _context;
public ImpCondEntitlementHistoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

