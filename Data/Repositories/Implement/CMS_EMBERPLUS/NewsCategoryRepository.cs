namespace Data.Repositories.CMS_EMBERPLUS
{
public class NewsCategoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.NewsCategory>, INewsCategoryRepository
{
private readonly CmsEmberplusContext _context;
public NewsCategoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

