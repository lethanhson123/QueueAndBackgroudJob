namespace Data.Repositories.Csversion1
{
public class CaImgBblRepository : Repository<Data.Databases.Csversion1.CaImgBbl>, ICaImgBblRepository
{
private readonly Csversion1Context _context;
public CaImgBblRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

