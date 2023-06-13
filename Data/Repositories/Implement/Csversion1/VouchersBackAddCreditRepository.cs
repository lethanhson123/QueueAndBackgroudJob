namespace Data.Repositories.Csversion1
{
public class VouchersBackAddCreditRepository : Repository<Data.Databases.Csversion1.VouchersBackAddCredit>, IVouchersBackAddCreditRepository
{
private readonly Csversion1Context _context;
public VouchersBackAddCreditRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

