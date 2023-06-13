namespace Data.Repositories.CMS_EMBERPLUS
{
public class CompanyRepository : Repository<Data.Databases.CMS_EMBERPLUS.Company>, ICompanyRepository
{
private readonly CmsEmberplusContext _context;
public CompanyRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

