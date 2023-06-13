namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IWebOrderDetailRepository : IRepository<Data.Databases.CMS_EMBERPLUS.WebOrderDetail>
	{
		public List<Data.Databases.CMS_EMBERPLUS.WebOrderDetail> GetByWhOcDeliveryDetailIDsToList(List<long> whOcDeliveryDetailIDs);
	}
}

