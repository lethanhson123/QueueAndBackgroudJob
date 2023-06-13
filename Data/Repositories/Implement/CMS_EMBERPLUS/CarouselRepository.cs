namespace Data.Repositories.CMS_EMBERPLUS
{
public class CarouselRepository : Repository<Data.Databases.CMS_EMBERPLUS.Carousel>, ICarouselRepository
{
private readonly CmsEmberplusContext _context;
public CarouselRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

