namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpCondConfigurationListRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpCondConfigurationList>, IImpCondConfigurationListRepository
{
private readonly CmsEmberplusContext _context;
public ImpCondConfigurationListRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

