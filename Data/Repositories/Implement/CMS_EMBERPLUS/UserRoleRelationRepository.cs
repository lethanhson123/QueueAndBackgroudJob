namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserRoleRelationRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserRoleRelation>, IUserRoleRelationRepository
{
private readonly CmsEmberplusContext _context;
public UserRoleRelationRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

