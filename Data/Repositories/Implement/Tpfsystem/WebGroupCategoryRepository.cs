namespace Data.Repositories.Tpfsystem
{
public class WebGroupCategoryRepository : Repository<Data.Databases.Tpfsystem.WebGroupCategory>, IWebGroupCategoryRepository
{
private readonly TpfsystemContext _context;
public WebGroupCategoryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

