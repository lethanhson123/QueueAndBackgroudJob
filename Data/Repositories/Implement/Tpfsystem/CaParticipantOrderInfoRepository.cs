namespace Data.Repositories.Tpfsystem
{
public class CaParticipantOrderInfoRepository : Repository<Data.Databases.Tpfsystem.CaParticipantOrderInfo>, ICaParticipantOrderInfoRepository
{
private readonly TpfsystemContext _context;
public CaParticipantOrderInfoRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

