namespace Data.Repositories.Csversion1
{
public class CaSchoolOrgContactBakDeleteRepository : Repository<Data.Databases.Csversion1.CaSchoolOrgContactBakDelete>, ICaSchoolOrgContactBakDeleteRepository
{
private readonly Csversion1Context _context;
public CaSchoolOrgContactBakDeleteRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

