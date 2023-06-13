namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsBgimageEditorRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsBgimageEditor>, ICmsBgimageEditorRepository
{
private readonly CmsEmberplusContext _context;
public CmsBgimageEditorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

