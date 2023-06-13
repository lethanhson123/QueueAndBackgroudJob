namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface IWhOcDeliveryDetailRepository : IRepository<Data.Databases.CMS_EMBERPLUS.WhOcDeliveryDetail>
	{
		public List<Data.Databases.CMS_EMBERPLUS.WhOcDeliveryDetail> GetByOcDelIdToList(long ocDelId);
	}
}

