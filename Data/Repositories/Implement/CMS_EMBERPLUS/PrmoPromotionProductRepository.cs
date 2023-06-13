namespace Data.Repositories.CMS_EMBERPLUS
{
public class PrmoPromotionProductRepository : Repository<Data.Databases.CMS_EMBERPLUS.PrmoPromotionProduct>, IPrmoPromotionProductRepository
{
private readonly CmsEmberplusContext _context;
public PrmoPromotionProductRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

