namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsImageEditorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsImageEditor>, ICmsImageEditorRepository
{
private readonly CmsEmberplusContext _context;
public CmsImageEditorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

