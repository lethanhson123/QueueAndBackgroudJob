namespace Data.Repositories.Tpfsystem
{
public class CaParticipantOrderDetailBackup20201113Repository : Repository<Data.Databases.Tpfsystem.CaParticipantOrderDetailBackup20201113>, ICaParticipantOrderDetailBackup20201113Repository
{
private readonly TpfsystemContext _context;
public CaParticipantOrderDetailBackup20201113Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

