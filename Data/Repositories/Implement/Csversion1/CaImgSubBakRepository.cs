namespace Data.Repositories.Csversion1
{
public class CaImgSubBakRepository : Repository<Data.Databases.Csversion1.CaImgSubBak>, ICaImgSubBakRepository
{
private readonly Csversion1Context _context;
public CaImgSubBakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

