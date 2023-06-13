namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcParticipantProgramRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcParticipantProgram>, ICalcParticipantProgramRepository
{
private readonly CmsEmberplusContext _context;
public CalcParticipantProgramRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

