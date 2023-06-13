namespace Data.Repositories.Tpfsystem
{
public class ClientWebAccountBakUpdateProfileRepository : Repository<Data.Databases.Tpfsystem.ClientWebAccountBakUpdateProfile>, IClientWebAccountBakUpdateProfileRepository
{
private readonly TpfsystemContext _context;
public ClientWebAccountBakUpdateProfileRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

