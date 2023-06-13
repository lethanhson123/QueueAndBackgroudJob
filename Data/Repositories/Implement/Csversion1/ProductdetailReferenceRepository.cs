namespace Data.Repositories.Csversion1
{
public class ProductdetailReferenceRepository : Repository<Data.Databases.Csversion1.ProductdetailReference>, IProductdetailReferenceRepository
{
private readonly Csversion1Context _context;
public ProductdetailReferenceRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

