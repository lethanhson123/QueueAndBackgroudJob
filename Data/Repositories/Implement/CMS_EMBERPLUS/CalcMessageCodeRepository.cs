namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcMessageCodeRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcMessageCode>, ICalcMessageCodeRepository
{
private readonly CmsEmberplusContext _context;
public CalcMessageCodeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

