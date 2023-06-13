namespace Data.Repositories.CMS_EMBERPLUS
{
public class NewsRepository : Repository<Data.Databases.CMS_EMBERPLUS.News>, INewsRepository
{
private readonly CmsEmberplusContext _context;
public NewsRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

