namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantItemDetailRepository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantItemDetail>, IVCaReportParticipantItemDetailRepository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantItemDetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

