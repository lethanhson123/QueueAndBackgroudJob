namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpTemplateListRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpTemplateList>, IImpTemplateListRepository
{
private readonly CmsEmberplusContext _context;
public ImpTemplateListRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

