namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcParticipantRejecttionRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcParticipantRejecttion>, ICalcParticipantRejecttionRepository
{
private readonly CmsEmberplusContext _context;
public CalcParticipantRejecttionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

