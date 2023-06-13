namespace Data.Repositories.CMS_EMBERPLUS
{
public class VParticipantRepository : Repository<Data.Databases.CMS_EMBERPLUS.VParticipant>, IVParticipantRepository
{
private readonly CmsEmberplusContext _context;
public VParticipantRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

