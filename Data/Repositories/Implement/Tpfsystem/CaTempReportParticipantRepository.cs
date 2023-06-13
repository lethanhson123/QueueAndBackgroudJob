namespace Data.Repositories.Tpfsystem
{
public class CaTempReportParticipantRepository : Repository<Data.Databases.Tpfsystem.CaTempReportParticipant>, ICaTempReportParticipantRepository
{
private readonly TpfsystemContext _context;
public CaTempReportParticipantRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

