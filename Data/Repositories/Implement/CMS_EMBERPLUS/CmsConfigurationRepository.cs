namespace Data.Repositories.CMS_EMBERPLUS
{
	public class CmsConfigurationRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfiguration>, ICmsConfigurationRepository
	{
		private readonly CmsEmberplusContext _context;
		public CmsConfigurationRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public Data.Databases.CMS_EMBERPLUS.CmsConfiguration GetCompanyIDAndStatus(int companyID, int status)
		{
			var result = _context.Set<Data.Databases.CMS_EMBERPLUS.CmsConfiguration>().AsNoTracking().FirstOrDefault(item => item.CompanyId == companyID && item.Status == status);
			return result;
		}
	}
}

