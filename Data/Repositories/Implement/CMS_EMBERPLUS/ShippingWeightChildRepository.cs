namespace Data.Repositories.CMS_EMBERPLUS
{
public class ShippingWeightChildRepository : Repository<Data.Databases.CMS_EMBERPLUS.ShippingWeightChild>, IShippingWeightChildRepository
{
private readonly CmsEmberplusContext _context;
public ShippingWeightChildRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

