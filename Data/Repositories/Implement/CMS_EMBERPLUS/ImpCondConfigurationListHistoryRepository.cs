namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpCondConfigurationListHistoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpCondConfigurationListHistory>, IImpCondConfigurationListHistoryRepository
{
private readonly CmsEmberplusContext _context;
public ImpCondConfigurationListHistoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

