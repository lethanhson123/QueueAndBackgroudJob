namespace Data.Repositories.Tpfsystem
{
public class VCaReportParticipantRawDatumRepository : Repository<Data.Databases.Tpfsystem.VCaReportParticipantRawDatum>, IVCaReportParticipantRawDatumRepository
{
private readonly TpfsystemContext _context;
public VCaReportParticipantRawDatumRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

