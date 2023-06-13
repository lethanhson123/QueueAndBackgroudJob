namespace Data.Repositories.TPFServices
{
public class ScheduleCallOnShopRepository : Repository<Data.Databases.TPFServices.ScheduleCallOnShop>, IScheduleCallOnShopRepository
{
private readonly TpfservicesContext _context;
public ScheduleCallOnShopRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

