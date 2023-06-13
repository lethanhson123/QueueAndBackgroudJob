namespace Data.Repositories.CMS_EMBERPLUS
{
public class UserEmailReminderRepository : Repository<Data.Databases.CMS_EMBERPLUS.UserEmailReminder>, IUserEmailReminderRepository
{
private readonly CmsEmberplusContext _context;
public UserEmailReminderRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

