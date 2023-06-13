namespace Data.Repositories.TPFServices
{
public class ImportParticipantRepository : Repository<Data.Databases.TPFServices.ImportParticipant>, IImportParticipantRepository
{
private readonly TpfservicesContext _context;
public ImportParticipantRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

