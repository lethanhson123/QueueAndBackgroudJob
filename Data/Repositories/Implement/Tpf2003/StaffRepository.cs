namespace Data.Repositories.Tpf2003
{
public class StaffRepository : Repository<Data.Databases.Tpf2003.Staff>, IStaffRepository
{
private readonly Tpf2003Context _context;
public StaffRepository(Tpf2003Context context) : base(context)
{
_context = context;
}
}
}

