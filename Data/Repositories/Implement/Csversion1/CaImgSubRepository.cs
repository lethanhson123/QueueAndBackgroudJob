namespace Data.Repositories.Csversion1
{
public class CaImgSubRepository : Repository<Data.Databases.Csversion1.CaImgSub>, ICaImgSubRepository
{
private readonly Csversion1Context _context;
public CaImgSubRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

