namespace Data.Repositories.TPFServices
{
public class ImportOrganisationRepository : Repository<Data.Databases.TPFServices.ImportOrganisation>, IImportOrganisationRepository
{
private readonly TpfservicesContext _context;
public ImportOrganisationRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

