namespace Data.Repositories.CMS_EMBERPLUS
{
public class ImpPostFflogRepository : Repository<Data.Databases.CMS_EMBERPLUS.ImpPostFflog>, IImpPostFflogRepository
{
private readonly CmsEmberplusContext _context;
public ImpPostFflogRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

