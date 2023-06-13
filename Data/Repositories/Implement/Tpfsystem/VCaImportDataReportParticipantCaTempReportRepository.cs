namespace Data.Repositories.Tpfsystem
{
public class VCaImportDataReportParticipantCaTempReportRepository : Repository<Data.Databases.Tpfsystem.VCaImportDataReportParticipantCaTempReport>, IVCaImportDataReportParticipantCaTempReportRepository
{
private readonly TpfsystemContext _context;
public VCaImportDataReportParticipantCaTempReportRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

