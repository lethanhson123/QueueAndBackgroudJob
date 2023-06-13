namespace Data.Repositories.CMS_EMBERPLUS
{
public class MetaResourceRepository : Repository<Data.Databases.CMS_EMBERPLUS.MetaResource>, IMetaResourceRepository
{
private readonly CmsEmberplusContext _context;
public MetaResourceRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

