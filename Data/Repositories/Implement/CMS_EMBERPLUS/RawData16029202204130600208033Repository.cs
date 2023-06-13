namespace Data.Repositories.CMS_EMBERPLUS
{
public class RawData16029202204130600208033Repository : Repository<Data.Databases.CMS_EMBERPLUS.RawData16029202204130600208033>, IRawData16029202204130600208033Repository
{
private readonly CmsEmberplusContext _context;
public RawData16029202204130600208033Repository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

