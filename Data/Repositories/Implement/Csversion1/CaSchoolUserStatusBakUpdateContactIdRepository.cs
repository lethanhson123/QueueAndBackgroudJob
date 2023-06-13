namespace Data.Repositories.Csversion1
{
public class CaSchoolUserStatusBakUpdateContactIdRepository : Repository<Data.Databases.Csversion1.CaSchoolUserStatusBakUpdateContactId>, ICaSchoolUserStatusBakUpdateContactIdRepository
{
private readonly Csversion1Context _context;
public CaSchoolUserStatusBakUpdateContactIdRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

