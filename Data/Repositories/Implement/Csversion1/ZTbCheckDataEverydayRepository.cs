namespace Data.Repositories.Csversion1
{
public class ZTbCheckDataEverydayRepository : Repository<Data.Databases.Csversion1.ZTbCheckDataEveryday>, IZTbCheckDataEverydayRepository
{
private readonly Csversion1Context _context;
public ZTbCheckDataEverydayRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

