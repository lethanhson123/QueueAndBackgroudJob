namespace Data.Repositories.Csversion1
{
public class ProductdetailRepository : Repository<Data.Databases.Csversion1.Productdetail>, IProductdetailRepository
{
private readonly Csversion1Context _context;
public ProductdetailRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

