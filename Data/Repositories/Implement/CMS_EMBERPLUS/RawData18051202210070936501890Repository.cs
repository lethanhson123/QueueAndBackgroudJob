namespace Data.Repositories.CMS_EMBERPLUS
{
public class RawData18051202210070936501890Repository : Repository<Data.Databases.CMS_EMBERPLUS.RawData18051202210070936501890>, IRawData18051202210070936501890Repository
{
private readonly CmsEmberplusContext _context;
public RawData18051202210070936501890Repository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

