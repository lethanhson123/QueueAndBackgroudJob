namespace Data.Repositories.CMS_EMBERPLUS
{
public class WidgetBiToolReportRepository : Repository<Data.Databases.CMS_EMBERPLUS.WidgetBiToolReport>, IWidgetBiToolReportRepository
{
private readonly CmsEmberplusContext _context;
public WidgetBiToolReportRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

