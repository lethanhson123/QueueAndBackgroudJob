namespace Data.Repositories.Csversion1
{
public class VGetcavreditRepository : Repository<Data.Databases.Csversion1.VGetcavredit>, IVGetcavreditRepository
{
private readonly Csversion1Context _context;
public VGetcavreditRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

