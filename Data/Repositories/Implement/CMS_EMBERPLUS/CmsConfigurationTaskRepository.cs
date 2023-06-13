namespace Data.Repositories.CMS_EMBERPLUS
{
	public class CmsConfigurationTaskRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationTask>, ICmsConfigurationTaskRepository
	{
		private readonly CmsEmberplusContext _context;
		public CmsConfigurationTaskRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public Data.Databases.CMS_EMBERPLUS.CmsConfigurationTask GetCompanyIDAndConfigIDAndIsRun(int companyID, int configID, bool isRun)
		{
			var result = _context.Set<Data.Databases.CMS_EMBERPLUS.CmsConfigurationTask>().AsNoTracking().FirstOrDefault(item => item.CompanyId == companyID && item.ConfigId == configID && item.IsRun == isRun);
			return result;
		}
	}
}

