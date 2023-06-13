namespace Data.Repositories.Csversion1
{
public class CaProductProfilePreviewRepository : Repository<Data.Databases.Csversion1.CaProductProfilePreview>, ICaProductProfilePreviewRepository
{
private readonly Csversion1Context _context;
public CaProductProfilePreviewRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

