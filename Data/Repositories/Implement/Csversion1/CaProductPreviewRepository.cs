namespace Data.Repositories.Csversion1
{
public class CaProductPreviewRepository : Repository<Data.Databases.Csversion1.CaProductPreview>, ICaProductPreviewRepository
{
private readonly Csversion1Context _context;
public CaProductPreviewRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

