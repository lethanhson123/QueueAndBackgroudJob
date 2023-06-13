namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserRepository : Repository<Data.Databases.CMS_EMBERPLUS.User>, IUserRepository
{
private readonly CmsEmberplusContext _context;
public UserRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

