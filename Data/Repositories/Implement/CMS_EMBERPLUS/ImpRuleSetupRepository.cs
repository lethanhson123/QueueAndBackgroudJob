namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpRuleSetupRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpRuleSetup>, IImpRuleSetupRepository
{
private readonly CmsEmberplusContext _context;
public ImpRuleSetupRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

