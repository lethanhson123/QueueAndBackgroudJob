namespace Data.Repositories.Tpf2003
{
public class BinbaseRepository : Repository<Data.Databases.Tpf2003.Binbase>, IBinbaseRepository
{
private readonly Tpf2003Context _context;
public BinbaseRepository(Tpf2003Context context) : base(context)
{
_context = context;
}
}
}

