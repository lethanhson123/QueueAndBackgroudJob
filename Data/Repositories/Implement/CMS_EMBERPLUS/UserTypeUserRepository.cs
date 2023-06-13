namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserTypeUserRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserTypeUser>, IUserTypeUserRepository
{
private readonly CmsEmberplusContext _context;
public UserTypeUserRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

