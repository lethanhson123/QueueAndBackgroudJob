namespace Data.Repositories.CMS_EMBERPLUS
{
public class CmsTriggerEmailToRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsTriggerEmailTo>, ICmsTriggerEmailToRepository
{
private readonly CmsEmberplusContext _context;
public CmsTriggerEmailToRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

