namespace Data.Repositories.Csversion1
{
public class VCablastCentreDayPerStateStateSchoolRepository : Repository<Data.Databases.Csversion1.VCablastCentreDayPerStateStateSchool>, IVCablastCentreDayPerStateStateSchoolRepository
{
private readonly Csversion1Context _context;
public VCablastCentreDayPerStateStateSchoolRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

