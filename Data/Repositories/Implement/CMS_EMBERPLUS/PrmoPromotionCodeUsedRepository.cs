namespace Data.Repositories.CMS_EMBERPLUS
{
public class PrmoPromotionCodeUsedRepository : Repository<Data.Databases.CMS_EMBERPLUS.PrmoPromotionCodeUsed>, IPrmoPromotionCodeUsedRepository
{
private readonly CmsEmberplusContext _context;
public PrmoPromotionCodeUsedRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

