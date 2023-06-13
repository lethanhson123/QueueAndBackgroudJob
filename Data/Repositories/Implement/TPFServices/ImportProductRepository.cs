namespace Data.Repositories.TPFServices
{
public class ImportProductRepository : Repository<Data.Databases.TPFServices.ImportProduct>, IImportProductRepository
{
private readonly TpfservicesContext _context;
public ImportProductRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

