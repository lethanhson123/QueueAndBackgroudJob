namespace Data.Repositories.TPFServices
{
public class FfImportTransactionRepository : Repository<Data.Databases.TPFServices.FfImportTransaction>, IFfImportTransactionRepository
{
private readonly TpfservicesContext _context;
public FfImportTransactionRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

