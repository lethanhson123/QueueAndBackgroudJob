namespace Data.Repositories.CMS_EMBERPLUS
{
public class MetaAddressRepository : Repository<Data.Databases.CMS_EMBERPLUS.MetaAddress>, IMetaAddressRepository
{
private readonly CmsEmberplusContext _context;
public MetaAddressRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

