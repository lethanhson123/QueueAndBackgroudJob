namespace Data.Repositories.CMS_EMBERPLUS
{
public class EmailsWithIssueRepository : Repository<Data.Databases.CMS_EMBERPLUS.EmailsWithIssue>, IEmailsWithIssueRepository
{
private readonly CmsEmberplusContext _context;
public EmailsWithIssueRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

