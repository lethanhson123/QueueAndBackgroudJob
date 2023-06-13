namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcSeasonCreditHistoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcSeasonCreditHistory>, ICalcSeasonCreditHistoryRepository
{
private readonly CmsEmberplusContext _context;
public CalcSeasonCreditHistoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

