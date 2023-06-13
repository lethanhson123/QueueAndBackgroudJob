namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsBarcodeRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsBarcode>, ICmsBarcodeRepository
{
private readonly CmsEmberplusContext _context;
public CmsBarcodeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

