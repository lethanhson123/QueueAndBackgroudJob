namespace Data.Repositories.CMS_EMBERPLUS
{
public class WebOrderDetailSubItemRepository : Repository<Data.Databases.CMS_EMBERPLUS.WebOrderDetailSubItem>, IWebOrderDetailSubItemRepository
{
private readonly CmsEmberplusContext _context;
public WebOrderDetailSubItemRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

