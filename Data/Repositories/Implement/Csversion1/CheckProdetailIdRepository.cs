namespace Data.Repositories.Csversion1
{
public class CheckProdetailIdRepository : Repository<Data.Databases.Csversion1.CheckProdetailId>, ICheckProdetailIdRepository
{
private readonly Csversion1Context _context;
public CheckProdetailIdRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

