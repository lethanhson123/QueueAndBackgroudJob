namespace Data.Repositories.Tpfsystem
{
public class CaParticipantOrderInfoBackup20201113Repository : Repository<Data.Databases.Tpfsystem.CaParticipantOrderInfoBackup20201113>, ICaParticipantOrderInfoBackup20201113Repository
{
private readonly TpfsystemContext _context;
public CaParticipantOrderInfoBackup20201113Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

