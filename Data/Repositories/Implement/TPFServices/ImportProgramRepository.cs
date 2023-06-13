namespace Data.Repositories.TPFServices
{
public class ImportProgramRepository : Repository<Data.Databases.TPFServices.ImportProgram>, IImportProgramRepository
{
private readonly TpfservicesContext _context;
public ImportProgramRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

