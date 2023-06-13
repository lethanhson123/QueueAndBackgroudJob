namespace Data.Repositories.Csversion1
{
public class CataloguePaymentMethodRepository : Repository<Data.Databases.Csversion1.CataloguePaymentMethod>, ICataloguePaymentMethodRepository
{
private readonly Csversion1Context _context;
public CataloguePaymentMethodRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

