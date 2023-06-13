namespace Data.Repositories.Csversion1
{
public class CaPlayerProductBak20191205Repository : Repository<Data.Databases.Csversion1.CaPlayerProductBak20191205>, ICaPlayerProductBak20191205Repository
{
private readonly Csversion1Context _context;
public CaPlayerProductBak20191205Repository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

