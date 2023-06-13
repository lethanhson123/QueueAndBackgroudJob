namespace Data.Repositories.Csversion1
{
public class GroupTransactionFfRepository : Repository<Data.Databases.Csversion1.GroupTransactionFf>, IGroupTransactionFfRepository
{
private readonly Csversion1Context _context;
public GroupTransactionFfRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

