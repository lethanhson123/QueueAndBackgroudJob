namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsTextEditorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsTextEditor>, ICmsTextEditorRepository
{
private readonly CmsEmberplusContext _context;
public CmsTextEditorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

