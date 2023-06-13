namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantRawDataBakPhase4Repository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantRawDataBakPhase4>, IVCaReportParticipantRawDataBakPhase4Repository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantRawDataBakPhase4Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

