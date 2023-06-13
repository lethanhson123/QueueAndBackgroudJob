namespace Data.Repositories.CMS_EMBERPLUS
{
public class PrmoPromotionTypeRepository : Repository<Data.Databases.CMS_EMBERPLUS.PrmoPromotionType>, IPrmoPromotionTypeRepository
{
private readonly CmsEmberplusContext _context;
public PrmoPromotionTypeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

