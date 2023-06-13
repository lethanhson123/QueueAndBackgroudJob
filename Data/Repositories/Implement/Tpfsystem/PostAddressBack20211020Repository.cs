namespace Data.Repositories.Tpfsystem
{
public class PostAddressBack20211020Repository : Repository<Data.Databases.Tpfsystem.PostAddressBack20211020>, IPostAddressBack20211020Repository
{
private readonly TpfsystemContext _context;
public PostAddressBack20211020Repository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

