namespace Data.Repositories.Csversion1
{
public class CaBlastCentreSettingRepository : Repository<Data.Databases.Csversion1.CaBlastCentreSetting>, ICaBlastCentreSettingRepository
{
private readonly Csversion1Context _context;
public CaBlastCentreSettingRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

