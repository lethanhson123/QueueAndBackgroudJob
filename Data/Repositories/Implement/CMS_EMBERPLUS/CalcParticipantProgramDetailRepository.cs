namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcParticipantProgramDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcParticipantProgramDetail>, ICalcParticipantProgramDetailRepository
{
private readonly CmsEmberplusContext _context;
public CalcParticipantProgramDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

