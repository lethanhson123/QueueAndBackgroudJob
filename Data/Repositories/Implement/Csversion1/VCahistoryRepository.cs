namespace Data.Repositories.Csversion1
{
public class VCahistoryRepository : Repository<Data.Databases.Csversion1.VCahistory>, IVCahistoryRepository
{
private readonly Csversion1Context _context;
public VCahistoryRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

