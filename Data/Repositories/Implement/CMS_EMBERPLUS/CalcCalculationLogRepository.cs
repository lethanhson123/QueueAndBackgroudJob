namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcCalculationLogRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcCalculationLog>, ICalcCalculationLogRepository
	{
private readonly CmsEmberplusContext _context;
public CalcCalculationLogRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

