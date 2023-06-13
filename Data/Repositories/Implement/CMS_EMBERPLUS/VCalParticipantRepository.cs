namespace Data.Repositories.CMS_EMBERPLUS
{
public class VCalParticipantRepository : Repository<Data.Databases.CMS_EMBERPLUS.VCalParticipant>, IVCalParticipantRepository
{
private readonly CmsEmberplusContext _context;
public VCalParticipantRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

