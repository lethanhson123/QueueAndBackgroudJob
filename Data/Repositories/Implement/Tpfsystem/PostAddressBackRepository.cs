namespace Data.Repositories.Tpfsystem
{
public class PostAddressBackRepository : Repository<Data.Databases.Tpfsystem.PostAddressBack>, IPostAddressBackRepository
{
private readonly TpfsystemContext _context;
public PostAddressBackRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

