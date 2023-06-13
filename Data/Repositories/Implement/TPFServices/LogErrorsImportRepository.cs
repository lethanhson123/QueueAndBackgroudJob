namespace Data.Repositories.TPFServices
{
public class LogErrorsImportRepository : Repository<Data.Databases.TPFServices.LogErrorsImport>, ILogErrorsImportRepository
{
private readonly TpfservicesContext _context;
public LogErrorsImportRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

