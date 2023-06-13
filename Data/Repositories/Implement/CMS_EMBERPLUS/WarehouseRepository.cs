namespace Data.Repositories.CMS_EMBERPLUS
{
public class WarehouseRepository : Repository<Data.Databases.CMS_EMBERPLUS.Warehouse>, IWarehouseRepository
{
private readonly CmsEmberplusContext _context;
public WarehouseRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

