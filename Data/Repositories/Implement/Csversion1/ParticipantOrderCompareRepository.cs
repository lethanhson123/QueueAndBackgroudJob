namespace Data.Repositories.Csversion1
{
public class ParticipantOrderCompareRepository : Repository<Data.Databases.Csversion1.ParticipantOrderCompare>, IParticipantOrderCompareRepository
{
private readonly Csversion1Context _context;
public ParticipantOrderCompareRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

