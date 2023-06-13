namespace Data.Repositories.TPFServices
{
public class FfApiclientRepository : Repository<Data.Databases.TPFServices.FfApiclient>, IFfApiclientRepository
{
private readonly TpfservicesContext _context;
public FfApiclientRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

