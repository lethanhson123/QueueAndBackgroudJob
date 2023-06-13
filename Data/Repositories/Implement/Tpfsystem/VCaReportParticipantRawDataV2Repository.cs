namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantRawDataV2Repository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantRawDataV2>, IVCaReportParticipantRawDataV2Repository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantRawDataV2Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

