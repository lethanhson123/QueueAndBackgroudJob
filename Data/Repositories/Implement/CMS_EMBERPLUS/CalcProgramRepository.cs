namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcProgramRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcProgram>, ICalcProgramRepository
{
private readonly CmsEmberplusContext _context;
public CalcProgramRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

