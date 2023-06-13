namespace Data.Repositories.Tpfsystem
{
public class InvoiceRepository : Repository<Data.Databases.Tpfsystem.Invoice>, IInvoiceRepository
{
private readonly TpfsystemContext _context;
public InvoiceRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

