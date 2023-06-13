namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductWaveHouseRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductWaveHouse>, IProductWaveHouseRepository
{
private readonly CmsEmberplusContext _context;
public ProductWaveHouseRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

