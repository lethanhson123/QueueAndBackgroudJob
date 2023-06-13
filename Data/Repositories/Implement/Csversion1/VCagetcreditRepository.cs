namespace Data.Repositories.Csversion1
{
public class VCagetcreditRepository : Repository<Data.Databases.Csversion1.VCagetcredit>, IVCagetcreditRepository
{
private readonly Csversion1Context _context;
public VCagetcreditRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

