namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserAccountRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserAccount>, IUserAccountRepository
{
private readonly CmsEmberplusContext _context;
public UserAccountRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

