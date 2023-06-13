namespace Data.Repositories.Tpfsystem
{
public class CaParticipantOrderDetailRepository : Repository<Data.Databases.Tpfsystem.CaParticipantOrderDetail>, ICaParticipantOrderDetailRepository
{
private readonly TpfsystemContext _context;
public CaParticipantOrderDetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

