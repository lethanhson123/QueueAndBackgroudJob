namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpMappingRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpMapping>, IImpMappingRepository
{
private readonly CmsEmberplusContext _context;
public ImpMappingRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

