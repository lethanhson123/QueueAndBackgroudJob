namespace Data.Repositories.TPFServices
{
public class ImportEntityRepository : Repository<Data.Databases.TPFServices.ImportEntity>, IImportEntityRepository
{
private readonly TpfservicesContext _context;
public ImportEntityRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

