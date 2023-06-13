namespace Data.Repositories.OnlineSyncData
{
public class RoleRepository : Repository<Data.Databases.OnlineSyncData.Role>, IRoleRepository
{
private readonly OnlineSyncDataContext _context;
public RoleRepository(OnlineSyncDataContext context) : base(context)
{
_context = context;
}
}
}

