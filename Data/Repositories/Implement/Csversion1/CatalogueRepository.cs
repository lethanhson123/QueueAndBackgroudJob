namespace Data.Repositories.Csversion1
{
public class CatalogueRepository : Repository<Data.Databases.Csversion1.Catalogue>, ICatalogueRepository
{
private readonly Csversion1Context _context;
public CatalogueRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

