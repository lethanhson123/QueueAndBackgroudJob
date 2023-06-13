namespace Data.Repositories.Tpfsystem
{
public class VCaReminderEmailRepository : Repository<Data.Databases.Tpfsystem.VCaReminderEmail>, IVCaReminderEmailRepository
{
private readonly TpfsystemContext _context;
public VCaReminderEmailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

