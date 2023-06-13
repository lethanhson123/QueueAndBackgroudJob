namespace Data.Repositories.CMS_EMBERPLUS
{
public class CompanySmtpRepository : Repository<Data.Databases.CMS_EMBERPLUS.CompanySmtp>, ICompanySmtpRepository
{
private readonly CmsEmberplusContext _context;
public CompanySmtpRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

