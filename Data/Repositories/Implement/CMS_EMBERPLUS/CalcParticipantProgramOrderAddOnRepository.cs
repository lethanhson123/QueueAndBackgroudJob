namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcParticipantProgramOrderAddOnRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcParticipantProgramOrderAddOn>, ICalcParticipantProgramOrderAddOnRepository
{
private readonly CmsEmberplusContext _context;
public CalcParticipantProgramOrderAddOnRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

