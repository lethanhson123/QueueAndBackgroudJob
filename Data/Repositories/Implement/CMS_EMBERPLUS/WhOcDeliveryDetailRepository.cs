namespace Data.Repositories.CMS_EMBERPLUS
{
	public class WhOcDeliveryDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.WhOcDeliveryDetail>, IWhOcDeliveryDetailRepository
	{
		private readonly CmsEmberplusContext _context;
		public WhOcDeliveryDetailRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public List<Data.Databases.CMS_EMBERPLUS.WhOcDeliveryDetail> GetByOcDelIdToList(long ocDelId)
		{
			var result = _context.Set<Data.Databases.CMS_EMBERPLUS.WhOcDeliveryDetail>().AsNoTracking().Where(item => item.OcDelId == ocDelId).ToList();
			return result;
		}
	}
}

