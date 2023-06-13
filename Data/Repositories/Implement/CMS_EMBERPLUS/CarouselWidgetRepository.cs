namespace Data.Repositories.CMS_EMBERPLUS
{
public class CarouselWidgetRepository : Repository<Data.Databases.CMS_EMBERPLUS.CarouselWidget>, ICarouselWidgetRepository
{
private readonly CmsEmberplusContext _context;
public CarouselWidgetRepository(CmsEmberplusContext context) : base(context)
{
_context = context;
}
}
}

