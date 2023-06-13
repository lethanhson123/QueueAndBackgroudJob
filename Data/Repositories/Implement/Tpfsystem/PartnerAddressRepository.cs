namespace Data.Repositories.Tpfsystem
{
public class PartnerAddressRepository : Repository<Data.Databases.Tpfsystem.PartnerAddress>, IPartnerAddressRepository
{
private readonly TpfsystemContext _context;
public PartnerAddressRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

