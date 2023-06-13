namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcParticipantRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcParticipant>, ICalcParticipantRepository
{
private readonly CmsEmberplusContext _context;
public CalcParticipantRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

