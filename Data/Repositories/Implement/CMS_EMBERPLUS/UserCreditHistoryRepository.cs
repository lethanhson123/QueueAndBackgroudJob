namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserCreditHistoryRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserCreditHistory>, IUserCreditHistoryRepository
{
private readonly CmsEmberplusContext _context;
public UserCreditHistoryRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

