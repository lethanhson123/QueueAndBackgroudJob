namespace Data.Repositories.CMS_EMBERPLUS
{
public class CarouselItemRepository : Repository<Data.Databases.CMS_EMBERPLUS.CarouselItem>, ICarouselItemRepository
{
private readonly CmsEmberplusContext _context;
public CarouselItemRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

