namespace Data.Repositories.Csversion1
{
public class CheckNewPriceRepository : Repository<Data.Databases.Csversion1.CheckNewPrice>, ICheckNewPriceRepository
{
private readonly Csversion1Context _context;
public CheckNewPriceRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

