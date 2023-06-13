namespace Data.Repositories.Csversion1
{
public class CaAvalableCheckSendMailRepository : Repository<Data.Databases.Csversion1.CaAvalableCheckSendMail>, ICaAvalableCheckSendMailRepository
{
private readonly Csversion1Context _context;
public CaAvalableCheckSendMailRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

