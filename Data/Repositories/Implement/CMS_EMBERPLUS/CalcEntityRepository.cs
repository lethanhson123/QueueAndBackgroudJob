namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcEntityRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcEntity>, ICalcEntityRepository
{
private readonly CmsEmberplusContext _context;
public CalcEntityRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

