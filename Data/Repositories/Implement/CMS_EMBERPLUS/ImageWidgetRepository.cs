namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImageWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImageWidget>, IImageWidgetRepository
{
private readonly CmsEmberplusContext _context;
public ImageWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

