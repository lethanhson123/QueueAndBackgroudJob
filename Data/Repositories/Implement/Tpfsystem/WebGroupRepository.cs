namespace Data.Repositories.Tpfsystem
{
public class WebGroupRepository : Repository<Data.Databases.Tpfsystem.WebGroup>, IWebGroupRepository
{
private readonly TpfsystemContext _context;
public WebGroupRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

