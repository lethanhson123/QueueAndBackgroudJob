namespace Data.Repositories.CMS_EMBERPLUS
{
	public interface ICmsTriggerEmailRepository : IRepository<Data.Databases.CMS_EMBERPLUS.CmsTriggerEmail>
	{
		public Task<Data.Databases.CMS_EMBERPLUS.CmsTriggerEmail> GetByCompanyIDAndKeyAndStatus(int companyID, string key, int status);
	}
}

