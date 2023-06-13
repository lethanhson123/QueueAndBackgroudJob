namespace Data.Repositories.CMS_EMBERPLUS
{
public class CompanyOptionRepository : Repository<Data.Databases.CMS_EMBERPLUS.CompanyOption>, ICompanyOptionRepository
{
private readonly CmsEmberplusContext _context;
public CompanyOptionRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

