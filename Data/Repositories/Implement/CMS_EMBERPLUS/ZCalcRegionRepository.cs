namespace Data.Repositories.CMS_EMBERPLUS
{
public class ZCalcRegionRepository : Repository<Data.Databases.CMS_EMBERPLUS.ZCalcRegion>, IZCalcRegionRepository
{
private readonly CmsEmberplusContext _context;
public ZCalcRegionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

