namespace Data.Repositories.CMS_EMBERPLUS
{
public class CalcOrganisationRepository : Repository<Data.Databases.CMS_EMBERPLUS.CalcOrganisation>, ICalcOrganisationRepository
{
private readonly CmsEmberplusContext _context;
public CalcOrganisationRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

