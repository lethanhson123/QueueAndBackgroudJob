namespace Data.Repositories.CMS_EMBERPLUS
{
public class PostAddressRepository : Repository<Data.Databases.CMS_EMBERPLUS.PostAddress>, IPostAddressRepository
{
private readonly CmsEmberplusContext _context;
public PostAddressRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

