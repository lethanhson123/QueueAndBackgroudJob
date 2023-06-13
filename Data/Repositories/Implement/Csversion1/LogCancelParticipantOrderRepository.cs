namespace Data.Repositories.Csversion1
{
public class LogCancelParticipantOrderRepository : Repository<Data.Databases.Csversion1.LogCancelParticipantOrder>, ILogCancelParticipantOrderRepository
{
private readonly Csversion1Context _context;
public LogCancelParticipantOrderRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

