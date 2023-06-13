namespace Data.Repositories.Tpfsystem
{
public class PostAddressRepository : Repository<Data.Databases.Tpfsystem.PostAddress>, IPostAddressRepository
{
private readonly TpfsystemContext _context;
public PostAddressRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

