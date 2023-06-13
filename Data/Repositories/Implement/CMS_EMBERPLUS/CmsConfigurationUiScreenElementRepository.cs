namespace Data.Repositories.CMS_EMBERPLUS
{
    public class CmsConfigurationUiScreenElementRepository : Repository<Data.Databases.CMS_EMBERPLUS.CmsConfigurationUiScreenElement>, ICmsConfigurationUiScreenElementRepository
    {
        private readonly CmsEmberplusContext _context;
        public CmsConfigurationUiScreenElementRepository(CmsEmberplusContext context) : base(context)
        {
            _context = context;
        }
    }
}

