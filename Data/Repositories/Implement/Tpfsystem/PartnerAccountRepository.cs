namespace Data.Repositories.Tpfsystem
{
public class PartnerAccountRepository : Repository<Data.Databases.Tpfsystem.PartnerAccount>, IPartnerAccountRepository
{
private readonly TpfsystemContext _context;
public PartnerAccountRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

