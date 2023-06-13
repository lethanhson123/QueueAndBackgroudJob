namespace Data.Repositories.Tpfsystem
{
public class ParticipantProductRepository : Repository<Data.Databases.Tpfsystem.ParticipantProduct>, IParticipantProductRepository
{
private readonly TpfsystemContext _context;
public ParticipantProductRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

