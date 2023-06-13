namespace Data.Repositories.Csversion1
{
public class PersonalisationRepository : Repository<Data.Databases.Csversion1.Personalisation>, IPersonalisationRepository
{
private readonly Csversion1Context _context;
public PersonalisationRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

