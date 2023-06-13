namespace Data.Repositories.CMS_EMBERPLUS
{
public class VCalParticipantAukRepository : Repository<Data.Databases.CMS_EMBERPLUS.VCalParticipantAuk>, IVCalParticipantAukRepository
{
private readonly CmsEmberplusContext _context;
public VCalParticipantAukRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

