namespace Data.Repositories.Csversion1
{
public class VCagetbblnewRepository : Repository<Data.Databases.Csversion1.VCagetbblnew>, IVCagetbblnewRepository
{
private readonly Csversion1Context _context;
public VCagetbblnewRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

