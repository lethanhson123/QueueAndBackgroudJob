namespace Data.Repositories.CMS_EMBERPLUS
{
    public class CmsPageRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsPage>, ICmsPageRepository
	{
		private readonly CmsEmberplusContext _context;
		public CmsPageRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}			
	}
}

