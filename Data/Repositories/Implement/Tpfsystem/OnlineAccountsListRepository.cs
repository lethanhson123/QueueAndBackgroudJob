namespace Data.Repositories.Tpfsystem
{
public class OnlineAccountsListRepository : Repository<Data.Databases.Tpfsystem.OnlineAccountsList>, IOnlineAccountsListRepository
{
private readonly TpfsystemContext _context;
public OnlineAccountsListRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

