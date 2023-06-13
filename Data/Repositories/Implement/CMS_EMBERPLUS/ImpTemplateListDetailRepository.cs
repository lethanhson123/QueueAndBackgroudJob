namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpTemplateListDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpTemplateListDetail>, IImpTemplateListDetailRepository
{
private readonly CmsEmberplusContext _context;
public ImpTemplateListDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

