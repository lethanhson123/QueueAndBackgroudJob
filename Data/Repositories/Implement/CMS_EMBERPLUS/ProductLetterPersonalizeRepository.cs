namespace Data.Repositories.CMS_EMBERPLUS
{
public class ProductLetterPersonalizeRepository : Repository<Data.Databases.CMS_EMBERPLUS.ProductLetterPersonalize>, IProductLetterPersonalizeRepository
{
private readonly CmsEmberplusContext _context;
public ProductLetterPersonalizeRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

