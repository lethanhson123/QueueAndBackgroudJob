namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantCentreRepository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantCentre>, IVCaReportParticipantCentreRepository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantCentreRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

