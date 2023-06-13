namespace Data.Repositories.CMS_EMBERPLUS
{
public class VCalParticipantBakBeforeAukRepository : Repository<Data.Databases.CMS_EMBERPLUS.VCalParticipantBakBeforeAuk>, IVCalParticipantBakBeforeAukRepository
{
private readonly CmsEmberplusContext _context;
public VCalParticipantBakBeforeAukRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

