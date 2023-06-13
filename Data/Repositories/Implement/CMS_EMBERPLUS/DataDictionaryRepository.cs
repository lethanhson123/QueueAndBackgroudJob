namespace Data.Repositories.CMS_EMBERPLUS
{
public class DataDictionaryRepository : Repository<Data.Databases.CMS_EMBERPLUS.DataDictionary>, IDataDictionaryRepository
{
private readonly CmsEmberplusContext _context;
public DataDictionaryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

