namespace Data.Repositories.CMS_EMBERPLUS
{
public class MetaExtentFieldRepository : Repository<Data.Databases.CMS_EMBERPLUS.MetaExtentField>, IMetaExtentFieldRepository
{
private readonly CmsEmberplusContext _context;
public MetaExtentFieldRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

