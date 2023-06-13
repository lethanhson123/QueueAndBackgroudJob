namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpSeasonRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpSeason>, IImpSeasonRepository
{
private readonly CmsEmberplusContext _context;
public ImpSeasonRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

