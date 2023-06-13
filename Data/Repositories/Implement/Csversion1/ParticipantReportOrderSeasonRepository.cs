namespace Data.Repositories.Csversion1
{
public class ParticipantReportOrderSeasonRepository : Repository<Data.Databases.Csversion1.ParticipantReportOrderSeason>, IParticipantReportOrderSeasonRepository
{
private readonly Csversion1Context _context;
public ParticipantReportOrderSeasonRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

