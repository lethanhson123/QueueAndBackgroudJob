namespace Data.Repositories.Csversion1
{
public class CaAvalableCheckSendMailTBakRepository : Repository<Data.Databases.Csversion1.CaAvalableCheckSendMailTBak>, ICaAvalableCheckSendMailTBakRepository
{
private readonly Csversion1Context _context;
public CaAvalableCheckSendMailTBakRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

