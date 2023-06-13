namespace Data.Repositories.Csversion1
{
public class CatalogueLiveHelpSettingRepository : Repository<Data.Databases.Csversion1.CatalogueLiveHelpSetting>, ICatalogueLiveHelpSettingRepository
{
private readonly Csversion1Context _context;
public CatalogueLiveHelpSettingRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

