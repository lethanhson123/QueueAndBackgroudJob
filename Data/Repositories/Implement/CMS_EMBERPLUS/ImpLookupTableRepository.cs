namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpLookupTableRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpLookupTable>, IImpLookupTableRepository
{
private readonly CmsEmberplusContext _context;
public ImpLookupTableRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

