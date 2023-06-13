namespace Data.Repositories.Csversion1
{
public class ImportTransactionServiceRepository : Repository<Data.Databases.Csversion1.ImportTransactionService>, IImportTransactionServiceRepository
{
private readonly Csversion1Context _context;
public ImportTransactionServiceRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

