namespace Data.Repositories.CMS_EMBERPLUS
{
public class RawDataTestRepository : Repository<Data.Databases.CMS_EMBERPLUS.RawDataTest>, IRawDataTestRepository
{
private readonly CmsEmberplusContext _context;
public RawDataTestRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

