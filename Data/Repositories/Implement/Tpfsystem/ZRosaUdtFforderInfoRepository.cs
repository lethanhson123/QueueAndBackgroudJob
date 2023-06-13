namespace Data.Repositories.Tpfsystem
{
public class ZRosaUdtFforderInfoRepository : Repository<Data.Databases.Tpfsystem.ZRosaUdtFforderInfo>, IZRosaUdtFforderInfoRepository
{
private readonly TpfsystemContext _context;
public ZRosaUdtFforderInfoRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

