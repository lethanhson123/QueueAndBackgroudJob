namespace Data.Repositories.CMS_EMBERPLUS
{
public class ExtendFieldRepository : Repository<Data.Databases.CMS_EMBERPLUS.ExtendField>, IExtendFieldRepository
{
private readonly CmsEmberplusContext _context;
public ExtendFieldRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

