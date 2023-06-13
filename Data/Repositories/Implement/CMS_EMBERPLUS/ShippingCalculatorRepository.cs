namespace Data.Repositories.CMS_EMBERPLUS
{
public class ShippingCalculatorRepository : Repository<Data.Databases.CMS_EMBERPLUS.ShippingCalculator>, IShippingCalculatorRepository
{
private readonly CmsEmberplusContext _context;
public ShippingCalculatorRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

