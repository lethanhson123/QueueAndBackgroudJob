namespace Data.Repositories.Tpfsystem
{
public class InvoiceDetailRepository : Repository<Data.Databases.Tpfsystem.InvoiceDetail>, IInvoiceDetailRepository
{
private readonly TpfsystemContext _context;
public InvoiceDetailRepository(TpfsystemContext context) : base(context)
{
_context = context;
}
}
}

