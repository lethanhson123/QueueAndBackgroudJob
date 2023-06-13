namespace Data.Repositories.TPFServices
{
public class ImportUserRepository : Repository<Data.Databases.TPFServices.ImportUser>, IImportUserRepository
{
private readonly TpfservicesContext _context;
public ImportUserRepository(TpfservicesContext context) : base(context)
{
_context = context;
}
}
}

