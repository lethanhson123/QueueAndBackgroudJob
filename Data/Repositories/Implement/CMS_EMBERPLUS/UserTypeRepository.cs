namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserTypeRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserType>, IUserTypeRepository
{
private readonly CmsEmberplusContext _context;
public UserTypeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

