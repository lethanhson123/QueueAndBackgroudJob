namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantItemDetailV2Repository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantItemDetailV2>, IVCaReportParticipantItemDetailV2Repository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantItemDetailV2Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

