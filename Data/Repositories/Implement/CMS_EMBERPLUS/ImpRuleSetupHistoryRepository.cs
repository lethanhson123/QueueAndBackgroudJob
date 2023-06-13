namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpRuleSetupHistoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpRuleSetupHistory>, IImpRuleSetupHistoryRepository
{
private readonly CmsEmberplusContext _context;
public ImpRuleSetupHistoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

