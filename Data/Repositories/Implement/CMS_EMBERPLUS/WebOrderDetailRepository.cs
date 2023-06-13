namespace Data.Repositories.CMS_EMBERPLUS
{
	public class WebOrderDetailRepository : Repository<Data.Databases.CMS_EMBERPLUS.WebOrderDetail>, IWebOrderDetailRepository
	{
		private readonly CmsEmberplusContext _context;
		public WebOrderDetailRepository(CmsEmberplusContext context) : base(context)
		{
			_context = context;
		}
		public List<Data.Databases.CMS_EMBERPLUS.WebOrderDetail> GetByWhOcDeliveryDetailIDsToList(List<long> whOcDeliveryDetailIDs)
		{
			var result = _context.Set<Data.Databases.CMS_EMBERPLUS.WebOrderDetail>().AsNoTracking().Where(item => whOcDeliveryDetailIDs.Contains(item.Id)).ToList();
			return result;
		}
	}
}

