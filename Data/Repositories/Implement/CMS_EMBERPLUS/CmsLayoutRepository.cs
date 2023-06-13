namespace Data.Repositories.CMS_EMBERPLUS
{
	public class CmsLayoutRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsLayout>, ICmsLayoutRepository
	{
		private readonly CmsEmberplusContext _context;
		public CmsLayoutRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}		
	}
}

