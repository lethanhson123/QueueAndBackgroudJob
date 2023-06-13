namespace Data.Repositories.CMS_EMBERPLUS
{
	public class CmsTriggerEmailRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsTriggerEmail>, ICmsTriggerEmailRepository
	{
		private readonly CmsEmberplusContext _context;
		public CmsTriggerEmailRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public async Task<Data.Databases.CMS_EMBERPLUS.CmsTriggerEmail> GetByCompanyIDAndKeyAndStatus(int companyID, string key, int status)
		{
			var result = await _context.Set<Data.Databases.CMS_EMBERPLUS.CmsTriggerEmail>().AsNoTracking().FirstOrDefaultAsync(model => model.CompanyId == companyID && model.Key == key && model.Status == status);
			return result;
		}
	}
}

