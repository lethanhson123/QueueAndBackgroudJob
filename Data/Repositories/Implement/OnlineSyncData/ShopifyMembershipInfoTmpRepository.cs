namespace Data.Repositories.OnlineSyncData
{
public class ShopifyMembershipInfoTmpRepository : Repository<Data.Databases.OnlineSyncData.ShopifyMembershipInfoTmp>, IShopifyMembershipInfoTmpRepository
{
private readonly OnlineSyncDataContext _context;
public ShopifyMembershipInfoTmpRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

