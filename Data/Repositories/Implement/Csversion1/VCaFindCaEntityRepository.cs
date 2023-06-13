namespace Data.Repositories.Csversion1
{
public class VCaFindCaEntityRepository : Repository<Data.Databases.Csversion1.VCaFindCaEntity>, IVCaFindCaEntityRepository
{
private readonly Csversion1Context _context;
public VCaFindCaEntityRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

