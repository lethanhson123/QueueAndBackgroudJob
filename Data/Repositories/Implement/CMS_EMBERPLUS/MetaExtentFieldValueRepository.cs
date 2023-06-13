namespace Data.Repositories.CMS_EMBERPLUS
{
public class MetaExtentFieldValueRepository : Repository<Data.Databases.CMS_EMBERPLUS.MetaExtentFieldValue>, IMetaExtentFieldValueRepository
{
private readonly CmsEmberplusContext _context;
public MetaExtentFieldValueRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

