namespace Data.Repositories.Tpfsystem
{
public class WebaccountGroupRepository : Repository<Data.Databases.Tpfsystem.WebaccountGroup>, IWebaccountGroupRepository
{
private readonly TpfsystemContext _context;
public WebaccountGroupRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

