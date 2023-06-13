namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpMappingSettingHistoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpMappingSettingHistory>, IImpMappingSettingHistoryRepository
{
private readonly CmsEmberplusContext _context;
public ImpMappingSettingHistoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

