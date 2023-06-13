namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcCalculationParticipantRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcCalculationParticipant>, ICalcCalculationParticipantRepository
{
private readonly CmsEmberplusContext _context;
public CalcCalculationParticipantRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

