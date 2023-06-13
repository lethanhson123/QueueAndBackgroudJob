namespace Data.Repositories.Csversion1
{
public class ImportTransactionRepository : Repository<Data.Databases.Csversion1.ImportTransaction>, IImportTransactionRepository
{
private readonly Csversion1Context _context;
public ImportTransactionRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

