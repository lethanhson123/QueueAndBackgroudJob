namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcRegionRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcRegion>, ICalcRegionRepository
{
private readonly CmsEmberplusContext _context;
public CalcRegionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

