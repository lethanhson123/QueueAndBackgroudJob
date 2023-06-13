namespace Data.Repositories.Csversion1
{
public class CaSchoolUpdateChangeAccountRepository : Repository<Data.Databases.Csversion1.CaSchoolUpdateChangeAccount>, ICaSchoolUpdateChangeAccountRepository
{
private readonly Csversion1Context _context;
public CaSchoolUpdateChangeAccountRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

