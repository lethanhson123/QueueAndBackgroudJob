namespace Data.Repositories.Tpfsystem
{
public class ClientDatumRepository : Repository<Data.Databases.Tpfsystem.ClientDatum>, IClientDatumRepository
{
private readonly TpfsystemContext _context;
public ClientDatumRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

