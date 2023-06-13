namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface ICmsConfigurationRepository : IRepository<Data.Databases.CMS_EMBERPLUS.CmsConfiguration>
	{
		public Data.Databases.CMS_EMBERPLUS.CmsConfiguration GetCompanyIDAndStatus(int companyID, int status);
	}
}

