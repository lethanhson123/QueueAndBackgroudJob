namespace Data.Repositories.Csversion1
{
public class XmlDatumRepository : Repository<Data.Databases.Csversion1.XmlDatum>, IXmlDatumRepository
{
private readonly Csversion1Context _context;
public XmlDatumRepository(Csversion1Context context) : base(context)
{
_context = context;
}
}
}

