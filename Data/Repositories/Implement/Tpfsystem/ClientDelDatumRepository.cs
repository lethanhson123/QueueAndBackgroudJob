namespace Data.Repositories.Tpfsystem
{
public class ClientDelDatumRepository : Repository<Data.Databases.Tpfsystem.ClientDelDatum>, IClientDelDatumRepository
{
private readonly TpfsystemContext _context;
public ClientDelDatumRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

