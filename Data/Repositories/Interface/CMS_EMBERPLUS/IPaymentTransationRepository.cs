namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IPaymentTransationRepository : IRepository<Data.Databases.CMS_EMBERPLUS.PaymentTransation>
	{
		public Task<Data.Databases.CMS_EMBERPLUS.PaymentTransation> GetByOrderIDAndStatus(long orderID, int status);
	}
}

