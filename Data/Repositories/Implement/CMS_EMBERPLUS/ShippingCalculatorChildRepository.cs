namespace Data.Repositories.CMS_EMBERPLUS
{
public class ShippingCalculatorChildRepository : Repository<Data.Databases.CMS_EMBERPLUS.ShippingCalculatorChild>, IShippingCalculatorChildRepository
{
private readonly CmsEmberplusContext _context;
public ShippingCalculatorChildRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

