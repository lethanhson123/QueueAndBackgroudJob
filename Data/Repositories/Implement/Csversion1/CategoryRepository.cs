namespace Data.Repositories.Csversion1
{
public class CategoryRepository : Repository<Data.Databases.Csversion1.Category>, ICategoryRepository
{
private readonly Csversion1Context _context;
public CategoryRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

