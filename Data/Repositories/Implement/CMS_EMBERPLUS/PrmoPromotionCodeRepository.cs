namespace Data.Repositories.CMS_EMBERPLUS
{
public class PrmoPromotionCodeRepository : Repository<Data.Databases.CMS_EMBERPLUS.PrmoPromotionCode>, IPrmoPromotionCodeRepository
{
private readonly CmsEmberplusContext _context;
public PrmoPromotionCodeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

