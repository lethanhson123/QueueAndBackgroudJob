namespace Data.Repositories.CMS_EMBERPLUS
{
public class SeasonRepository : Repository<Data.Databases.CMS_EMBERPLUS.Season>, ISeasonRepository
{
private readonly CmsEmberplusContext _context;
public SeasonRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

