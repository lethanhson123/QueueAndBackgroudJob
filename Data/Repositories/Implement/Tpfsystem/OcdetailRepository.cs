namespace Data.Repositories.Tpfsystem
{
public class OcdetailRepository : Repository<Data.Databases.Tpfsystem.Ocdetail>, IOcdetailRepository
{
private readonly TpfsystemContext _context;
public OcdetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

