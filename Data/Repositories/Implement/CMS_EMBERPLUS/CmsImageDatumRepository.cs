namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsImageDatumRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsImageDatum>, ICmsImageDatumRepository
{
private readonly CmsEmberplusContext _context;
public CmsImageDatumRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

