namespace Data.Repositories.Csversion1
{
public class ProductQtyRepository : Repository<Data.Databases.Csversion1.ProductQty>, IProductQtyRepository
{
private readonly Csversion1Context _context;
public ProductQtyRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

