namespace Data.Repositories.TPFServices
{
public class SeasonRepository : Repository<Data.Databases.TPFServices.Season>, ISeasonRepository
{
private readonly TpfservicesContext _context;
public SeasonRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

