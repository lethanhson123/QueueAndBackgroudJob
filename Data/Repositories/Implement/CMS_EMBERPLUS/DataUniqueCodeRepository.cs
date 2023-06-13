namespace Data.Repositories.CMS_EMBERPLUS
{
public class DataUniqueCodeRepository : Repository<Data.Databases.CMS_EMBERPLUS.DataUniqueCode>, IDataUniqueCodeRepository
{
private readonly CmsEmberplusContext _context;
public DataUniqueCodeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

