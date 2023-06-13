namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpMappingSettingRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpMappingSetting>, IImpMappingSettingRepository
{
private readonly CmsEmberplusContext _context;
public ImpMappingSettingRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

