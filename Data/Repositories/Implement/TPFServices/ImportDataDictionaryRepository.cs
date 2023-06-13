namespace Data.Repositories.TPFServices
{
public class ImportDataDictionaryRepository : Repository<Data.Databases.TPFServices.ImportDataDictionary>, IImportDataDictionaryRepository
{
private readonly TpfservicesContext _context;
public ImportDataDictionaryRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

