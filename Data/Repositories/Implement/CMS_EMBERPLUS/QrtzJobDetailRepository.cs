namespace Data.Repositories.CMS_EMBERPLUS
{
public class QrtzJobDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.QrtzJobDetail>, IQrtzJobDetailRepository
{
private readonly CmsEmberplusContext _context;
public QrtzJobDetailRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

