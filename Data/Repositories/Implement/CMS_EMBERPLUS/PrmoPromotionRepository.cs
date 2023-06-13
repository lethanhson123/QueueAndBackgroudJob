namespace Data.Repositories.CMS_EMBERPLUS
{
public class PrmoPromotionRepository : Repository<Data.Databases.CMS_EMBERPLUS.PrmoPromotion>, IPrmoPromotionRepository
{
private readonly CmsEmberplusContext _context;
public PrmoPromotionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

