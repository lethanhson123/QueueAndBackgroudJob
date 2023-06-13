namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcCalculationRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcCalculation>, ICalcCalculationRepository
{
private readonly CmsEmberplusContext _context;
public CalcCalculationRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

