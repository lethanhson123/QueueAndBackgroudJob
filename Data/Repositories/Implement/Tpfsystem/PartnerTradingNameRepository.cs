namespace Data.Repositories.Tpfsystem
{
public class PartnerTradingNameRepository : Repository<Data.Databases.Tpfsystem.PartnerTradingName>, IPartnerTradingNameRepository
{
private readonly TpfsystemContext _context;
public PartnerTradingNameRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

