namespace Data.Repositories.CMS_EMBERPLUS
{
public class PrmoPromotionCodeAssignUserRepository : Repository<Data.Databases.CMS_EMBERPLUS.PrmoPromotionCodeAssignUser>, IPrmoPromotionCodeAssignUserRepository
{
private readonly CmsEmberplusContext _context;
public PrmoPromotionCodeAssignUserRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

