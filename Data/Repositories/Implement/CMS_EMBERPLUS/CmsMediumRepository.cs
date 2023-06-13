namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsMediumRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsMedium>, ICmsMediumRepository
{
private readonly CmsEmberplusContext _context;
public CmsMediumRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

