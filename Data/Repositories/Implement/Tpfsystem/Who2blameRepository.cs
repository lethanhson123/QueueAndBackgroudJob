namespace Data.Repositories.Tpfsystem
{
public class Who2blameRepository : Repository<Data.Databases.Tpfsystem.Who2blame>, IWho2blameRepository
{
private readonly TpfsystemContext _context;
public Who2blameRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

