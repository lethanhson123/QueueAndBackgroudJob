namespace Data.Repositories.Csversion1
{
public class ItemRatingRepository : Repository<Data.Databases.Csversion1.ItemRating>, IItemRatingRepository
{
private readonly Csversion1Context _context;
public ItemRatingRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

