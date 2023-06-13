namespace Data.Repositories.TPFServices
{
public class ImportTransactionRepository : Repository<Data.Databases.TPFServices.ImportTransaction>, IImportTransactionRepository
{
private readonly TpfservicesContext _context;
public ImportTransactionRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

