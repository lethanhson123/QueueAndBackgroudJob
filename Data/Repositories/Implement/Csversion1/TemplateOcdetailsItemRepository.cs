namespace Data.Repositories.Csversion1
{
public class TemplateOcdetailsItemRepository : Repository<Data.Databases.Csversion1.TemplateOcdetailsItem>, ITemplateOcdetailsItemRepository
{
private readonly Csversion1Context _context;
public TemplateOcdetailsItemRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

