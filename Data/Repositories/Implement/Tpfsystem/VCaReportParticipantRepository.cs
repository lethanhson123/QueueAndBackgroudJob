namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantRepository : Repository<Data.Databases.Tpfsystem.VCaReportParticipant>, IVCaReportParticipantRepository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

