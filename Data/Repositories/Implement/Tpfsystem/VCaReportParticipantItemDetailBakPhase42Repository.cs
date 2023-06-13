namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantItemDetailBakPhase42Repository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantItemDetailBakPhase42>, IVCaReportParticipantItemDetailBakPhase42Repository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantItemDetailBakPhase42Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

