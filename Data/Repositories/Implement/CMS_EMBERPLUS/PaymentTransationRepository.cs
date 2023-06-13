namespace Data.Repositories.CMS_EMBERPLUS
{
	public class PaymentTransationRepository : Repository<Data.Databases.CMS_EMBERPLUS.PaymentTransation>, IPaymentTransationRepository
	{
		private readonly CmsEmberplusContext _context;
		public PaymentTransationRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public async Task<Data.Databases.CMS_EMBERPLUS.PaymentTransation> GetByOrderIDAndStatus(long orderID, int status)
		{
			var result = await _context.Set<Data.Databases.CMS_EMBERPLUS.PaymentTransation>().AsNoTracking().FirstOrDefaultAsync(model => model.OrderId == orderID && model.Status == status);
			return result;
		}
	}
}

