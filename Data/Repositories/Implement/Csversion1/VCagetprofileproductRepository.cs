namespace Data.Repositories.Csversion1
{
public class VCagetprofileproductRepository : Repository<Data.Databases.Csversion1.VCagetprofileproduct>, IVCagetprofileproductRepository
{
private readonly Csversion1Context _context;
public VCagetprofileproductRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

