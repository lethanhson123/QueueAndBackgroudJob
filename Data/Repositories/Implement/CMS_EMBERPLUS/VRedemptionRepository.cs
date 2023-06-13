namespace Data.Repositories.CMS_EMBERPLUS
{
public class VRedemptionRepository : Repository<Data.Databases.CMS_EMBERPLUS.VRedemption>, IVRedemptionRepository
{
private readonly CmsEmberplusContext _context;
public VRedemptionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

