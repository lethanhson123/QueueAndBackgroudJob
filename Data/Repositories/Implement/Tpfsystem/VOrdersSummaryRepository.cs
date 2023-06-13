namespace Data.Repositories.Tpfsystem
{
public class VOrdersSummaryRepository : Repository<Data.Databases.Tpfsystem.VOrdersSummary>, IVOrdersSummaryRepository
{
private readonly TpfsystemContext _context;
public VOrdersSummaryRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

