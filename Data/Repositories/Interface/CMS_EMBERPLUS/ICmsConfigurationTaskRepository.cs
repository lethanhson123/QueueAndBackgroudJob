namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface ICmsConfigurationTaskRepository : IRepository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationTask>
	{
		public Data.Databases.CMS_EMBERPLUS.CmsConfigurationTask GetCompanyIDAndConfigIDAndIsRun(int companyID, int configID, bool isRun);
	}	
}

