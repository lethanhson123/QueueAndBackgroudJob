namespace Data.Repositories.Csversion1
{
public class CaTagProdetailRepository : Repository<Data.Databases.Csversion1.CaTagProdetail>, ICaTagProdetailRepository
{
private readonly Csversion1Context _context;
public CaTagProdetailRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

