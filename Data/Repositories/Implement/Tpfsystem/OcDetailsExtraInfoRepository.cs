namespace Data.Repositories.Tpfsystem
{
public class OcDetailsExtraInfoRepository : Repository<Data.Databases.Tpfsystem.OcDetailsExtraInfo>, IOcDetailsExtraInfoRepository
{
private readonly TpfsystemContext _context;
public OcDetailsExtraInfoRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

