namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantSentPlayerRepository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantSentPlayer>, IVCaReportParticipantSentPlayerRepository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantSentPlayerRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

